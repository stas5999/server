import userManager from './user-manager';
import { useCallback, useState, useMemo, useEffect } from 'react';
import { RequestStatuses } from '../models/enums';
import { User } from 'oidc-client';

interface AuthenticationContext {
  isAuthenticated: boolean;
  signIn: () => void;
  signOut: () => void;
  requestStatus: RequestStatuses;
}

function useAuth(): AuthenticationContext {
  const [requestStatus, setRequestStatus] = useState<RequestStatuses>(
    RequestStatuses.IDLE
  );
  const [isAuthenticated, setAuthenticated] = useState<boolean>(false);

  useEffect(() => {
    setRequestStatus(RequestStatuses.PROCESSING);
    userManager
      .getUser()
      .then((user) => {
        setAuthenticated(user !== null);
        setRequestStatus(RequestStatuses.SUCCESS);
      })
      .catch((err) => {
        setRequestStatus(RequestStatuses.FAIL);
      });
  }, [userManager]);

  const signIn = useCallback(() => {
    userManager
      .signinRedirect()
      .then(() => {
        setAuthenticated(true);
        setRequestStatus(RequestStatuses.SUCCESS);
      })
      .catch((error) => {
        setRequestStatus(RequestStatuses.FAIL);
      });
  }, [userManager]);
  const signOut = useCallback(
    () =>
      userManager
        .signoutRedirect()
        .then(() => {
          setAuthenticated(false);
          setRequestStatus(RequestStatuses.SUCCESS);
        })
        .catch((error) => {
          setRequestStatus(RequestStatuses.FAIL);
        }),
    [userManager]
  );

  return {
    isAuthenticated,
    signIn,
    signOut,
    requestStatus,
  };
}

interface RedirectContext {
  signInCallback: (
    onSuccess: (user: User) => void,
    onError?: (err: any) => void
  ) => void;
  signInSilentCallback: (onError?: (err: any) => void) => void;
}

function useSignInRedirect(): RedirectContext {
  const signInCallback = useCallback(
    (onSuccess: (user: User) => void, onError?: (err: any) => void) => {
      userManager.signinCallback().then(onSuccess).catch(onError);
    },
    []
  );

  const signInSilentCallback = useCallback((onError?: (err: any) => void) => {
    userManager.signinSilentCallback().catch(onError);
  }, []);

  return { signInCallback, signInSilentCallback };
}

export { useAuth, useSignInRedirect };
