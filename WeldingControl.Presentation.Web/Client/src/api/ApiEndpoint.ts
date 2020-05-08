import querystring from 'querystring';
import { API_URL } from '../shared/constants';
import { Exception, ServerError } from '../models/exceptions';
import { removeEmptyProps } from '../shared/utils';
import userManager from '../auth/user-manager';

const defaultOptions: RequestInit = {
  credentials: 'same-origin' as RequestCredentials,
  headers: {
    Accept: 'application/json',
    'Content-Type': 'application/json',
  },
  redirect: 'follow' as RequestRedirect,
};

const getOptions = (): Promise<RequestInit> => {
  return userManager.getUser().then((user) => {
    if (user === null || !user.access_token) {
      return defaultOptions;
    }

    return Object.assign({}, defaultOptions, {
      headers: {
        Authorization: 'Bearer ' + user.access_token,
      },
    });
  });
};

const combineOptions = (
  options: RequestInit,
  customOptions?: Partial<RequestInit>
): RequestInit => {
  return Object.assign(options, customOptions);
};

function authenticated_fetch(
  input: RequestInfo,
  customOptions?: Partial<RequestInit>
): Promise<Response> {
  return getOptions().then((opt) => {
    const init =
      customOptions !== undefined ? combineOptions(opt, customOptions) : opt;

    return fetch(input, init).then((response) => {
      if (response.status === 401) {
        return userManager
          .signinSilent()
          .then((user) =>
            fetch(
              input,
              combineOptions(init, {
                headers: {
                  Authorization: 'Bearer ' + user.access_token,
                },
              })
            )
          )
          .catch((err) =>
            Promise.reject({
              status: response.status,
              errors: [],
              message: !err ? 'Ошибка при обновлении токена' : err,
            } as ServerError)
          );
      }

      if (response.status === 403) {
        return Promise.reject({
          status: response.status,
          errors: [],
          message: 'У вас нет доступа к данному ресурсу',
        } as ServerError);
      }

      return Promise.resolve(response);
    });
  });
}

const responseInterceptor = (response: Response): Promise<any> => {
  if (response.ok) {
    return response.json();
  }

  return response.json().then((json) => {
    const errors: Exception[] = (json.errors || []).map((e: Exception) => ({
      ...e,
    }));
    const serverError: ServerError = {
      status: response.status,
      errors: errors,
      message: 'Неизвестная ошибка',
    };
    return Promise.reject(serverError);
  });
};

export class ApiEndpoint {
  private readonly baseUrl: string;

  constructor(baseUrl = '') {
    this.baseUrl = API_URL + baseUrl;
  }

  combineUrl(url: string): string {
    return `${this.baseUrl}${url}`;
  }

  get(): Promise<any>;
  get(url: string): Promise<any>;
  get(query?: object): Promise<any>;
  get(url: string, query: object): Promise<any>;
  get(urlOrQuery: string | object = '', query?: object): Promise<any> {
    if (typeof urlOrQuery === 'object') {
      query = urlOrQuery;
      urlOrQuery = '';
    }

    let requestUrl = this.combineUrl(urlOrQuery);
    if (query) {
      requestUrl =
        requestUrl + '?' + querystring.stringify(removeEmptyProps(query));
    }
    return authenticated_fetch(requestUrl).then(responseInterceptor);
  }

  post(url: string, body: object | string): Promise<any>;
  post(url: string, body: FormData): Promise<any>;
  post(url: string, body: object | string | FormData): Promise<any> {
    const requestUrl = this.combineUrl(url);
    if (!(body instanceof FormData)) {
      body = JSON.stringify(removeEmptyProps(body));
    }

    return authenticated_fetch(requestUrl, {
      method: 'POST',
      body,
    }).then(responseInterceptor);
  }

  put(url: string, body: object): Promise<any>;
  put(url: string, body: FormData | string): Promise<any>;
  put(url: string, body: object | string | FormData): Promise<any> {
    const requestUrl = this.combineUrl(url);
    if (!(body instanceof FormData)) {
      body = JSON.stringify(removeEmptyProps(body));
    }

    return authenticated_fetch(requestUrl, {
      method: 'PUT',
      body,
    }).then(responseInterceptor);
  }

  delete(url: string): Promise<any>;
  delete(url: string, body: object): Promise<any>;
  delete(url: string, body?: object): Promise<any> {
    const requestUrl = this.combineUrl(url);

    return authenticated_fetch(requestUrl, {
      method: 'DELETE',
      body: body && JSON.stringify(removeEmptyProps(body)),
    }).then(responseInterceptor);
  }
}
