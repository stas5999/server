import React, { FunctionComponent } from 'react';
import MainLayout from '../../shared/layout/MainLayout';
import { testApi } from '../../api/a/a-api';
import { Button, Spinner } from 'react-bootstrap';
import { useAuth } from '../../auth/hooks';
import { RequestStatuses } from '../../models/enums';

const MainPage: FunctionComponent = () => {
  const { requestStatus, signIn, signOut } = useAuth();

  return (
    <MainLayout header={<h1>Hello</h1>}>
      {(requestStatus !== RequestStatuses.PROCESSING && (
        <>
          <Button onClick={signIn}>Войти</Button>
          <Button onClick={signOut}>Выйти</Button>
          <Button
            onClick={async () => {
              console.log(await testApi.get());
            }}
          >
            Проверить Api
          </Button>
        </>
      )) || (
        <Spinner animation="border" role="status">
          <span className="sr-only">Loading...</span>
        </Spinner>
      )}
    </MainLayout>
  );
};

export default MainPage;
