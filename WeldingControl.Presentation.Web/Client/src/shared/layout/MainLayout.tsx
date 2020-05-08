import React, { Component } from 'react';
import { Navbar, Nav, Container } from 'react-bootstrap';
import { IndexLinkContainer } from 'react-router-bootstrap';
import s from './styles.module.scss';

type OwnProps = {
  header?: JSX.Element | string;
};

type StateProps = {};

type DispatchProps = {};

type Props = OwnProps & StateProps & DispatchProps;

export default class MainLayout extends Component<Props> {
  render() {
    return (
      <>
        <Navbar variant="dark" bg="dark" expand="lg" fixed="top">
          <IndexLinkContainer to="/">
            <Navbar.Brand>Welding Control</Navbar.Brand>
          </IndexLinkContainer>
          <Nav className="mr-auto">
            {/* <LinkContainer to="/workers">
              <Nav.Link>Сварщики</Nav.Link>
            </LinkContainer> */}
          </Nav>
          <Nav></Nav>
          {/* <Navbar.Toggle aria-controls="basic-navbar-nav" />
          <Navbar.Collapse id="basic-navbar-nav"></Navbar.Collapse> */}
        </Navbar>
        <Container className={s.container}>
          <div className={s.header}>{this.props.header}</div>
          {this.props.children}
        </Container>
      </>
    );
  }
}
