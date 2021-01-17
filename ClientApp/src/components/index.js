import { render } from '@testing-library/react';
import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import './index.css';



/*const element=<h1 className="testClass"> WELCOME TO PRIDE WEDDING SERVICE  </h1>;
ReactDOM.render(element,document.getElementById('root')); */



/*const element2=<h1 className="testClass2">  </h1>;
ReactDOM.render(element2,document.getElementById('root2')); */


class Employee extends React.Component {
    addEmployee=()=>{
        alert("Create an account");
    }
    render(){
        return <div>
            <h1 className="testClass"> WELCOME TO PRIDE WEDDING SERVICE  </h1>
              <h1 className="testClass2">  </h1>
               <h2 className="testClass5"> CAPTURE  YOUR  DREAM  WEDDING </h2>
                 <h1>  </h1>
            <p>
                <button className="testClass4" onclick={this.addEmployee}>REGISTER NOW</button>
            </p> 
        </div>
    }
}

const element3=<Employee className="testClass2">  </Employee>;
ReactDOM.render(element3,document.getElementById('root3'));


//const element=(
// <div className="testClass"> 
// <h1> Welcome to the Pride Wedding Service! </h1>;
// <h1> Capture your dream wedding  </h1>
// </div>
// )

//ReactDOM.render(element,document.getElementById('root'))


// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals

