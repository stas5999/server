import React, { FunctionComponent } from 'react';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
import './App.scss';
import LoadingIndicator from './shared/components/loading-indicator/LoadingIndicator';
import { useSignInRedirect } from './auth/hooks';
import MainPage from './pages/main-page/MainPage';

const App: FunctionComponent = () => {
  const { signInCallback, signInSilentCallback } = useSignInRedirect();

  return (
    <>
      <LoadingIndicator />
      <BrowserRouter>
        <Switch>
          <Route
            path="/signin/silent"
            render={(props) => {
              signInSilentCallback();
              return null;
            }}
          />
          <Route
            path="/signin"
            render={(props) => {
              signInCallback(() => props.history.push('/'));
              return null;
            }}
          />
          <Route path="/" exact component={MainPage} />
        </Switch>
      </BrowserRouter>
    </>
  );
};

export default React.memo(App);
