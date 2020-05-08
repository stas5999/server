import { combineReducers } from 'redux';
import {
  LoadingState,
  loadingReducer,
} from './components/loading-indicator/reducer';

export type RootState = {
  loading: LoadingState;
};

export const rootReducer = () =>
  combineReducers<RootState>({
    loading: loadingReducer,
  });
