import React, { FunctionComponent } from 'react';
import { useSelector } from 'react-redux';
import { RootState } from '../../reducer';
import Spinner from 'react-bootstrap/Spinner';

import s from './styles.module.scss';

const LoadingIndicator: FunctionComponent = () => {
  const requestsNumber = useSelector(
    (state: RootState) => state.loading.requestsNumber
  );

  if (requestsNumber === 0) {
    return null;
  }

  return (
    <div className={s.container}>
      <Spinner animation="border" role="status">
        <span className="sr-only">Loading...</span>
      </Spinner>
    </div>
  );
};

export default LoadingIndicator;
