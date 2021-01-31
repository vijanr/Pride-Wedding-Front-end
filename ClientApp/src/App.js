import React from 'react';
import { BrowserRouter as Router, Switch, Route, Link } from "react-router-dom";
//import React, { Component } from './components';
//import { Route } from 'react-router';
//import { Layout } from './components/Layout';
//import { Home } from './components/Home';
//import { FetchData } from './components/FetchData';
//import { Counter } from './components/Counter';

import './App.css';
import "./index.css";
import "./welcome.css";
import "./selection.css";
import '../node_modules/bootstrap/dist/css/bootstrap.min.css';
import Welcome from "./components/welcome.component";
import Login from "./components/login.component";
import SignUp from "./components/signup.component";
import Selection from "./components/selection.component";
import Path from "./components/path.component";
import Client_Selection from "./components/client-selection.component";
import './custom.css'
//import react from 'react';

/*export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
        <Route path='/fetch-data' component={FetchData} />
      </Layout>
    );
  }
}*/

function App() {
  return (<Router>
    <div className="App">
      <nav className="navbar navbar-expand-lg navbar-light fixed-top">
        <div className="container">
          <Link>CALL US +9477423909 | CONTACT US</Link>
          <div className="collapse navbar-collapse" id="navbarTogglerDemo02">
            <ul className="navbar-nav ml-auto">
            
              <li className="nav-item">
                <Link className="nav-link" to={"/sign-up"}>Sign up</Link>
              </li>
            </ul>
          </div>
        </div>
      </nav>

      <div className="outer">
        <div className="inner">
          <Switch>
            <Route exact path='/' component={Selection} />
            <Route path="/register" component={Welcome} />
            <Route path="/path" component={Path} />
            <Route path="/sign-up" component={SignUp} />
            <Route path="/verify-login" component={Login} />
            <Route path="/client-selection" component={Client_Selection} />
            
          </Switch>
        </div>
      </div>
    </div></Router>
  );
}

export default App;