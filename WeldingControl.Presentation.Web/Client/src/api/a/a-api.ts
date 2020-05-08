import { ApiEndpoint } from '../ApiEndpoint';

const testEndpoint = new ApiEndpoint('/employees');

export const testApi = {
  get(): Promise<{
    greetings: string;
  }> {
    return testEndpoint.get();
  },
};
