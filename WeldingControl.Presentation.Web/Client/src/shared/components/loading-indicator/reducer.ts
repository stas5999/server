import { Reducer } from 'redux';

export type LoadingState = {
  requestsNumber: number;
};

const initialState: LoadingState = {
  requestsNumber: 0,
};

export const loadingReducer: Reducer<LoadingState> = (
  state = initialState,
  action
) => {
  const { type } = action;
  const matches = /(.*)_(START|SUCCESS|FAIL)/.exec(type);

  if (!matches) return state;

  const [, , requestState] = matches;

  const newNuberOfRequests =
    requestState === 'START'
      ? state.requestsNumber + 1
      : state.requestsNumber - 1;

  if (newNuberOfRequests < 0) {
    throw new Error(
      "Some ..._START actions with the 'preventLoadingIndicator === true' don't have this flag in corresponding ..._SUCCESS/..._FAIL actions."
    );
  }

  return {
    ...state,
    requestsNumber: newNuberOfRequests,
  };
};
