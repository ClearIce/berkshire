import React, { useEffect, useState } from "react";
import Particle from "react-particles-js";
import particlesConfig from "../assets/particlesConfig.json";
import Reason from "./Reason";

function App() {
  const [reasons, setReasons] = useState("");

  useEffect(() => {
    if (!reasons) {
      fetch('api/reasons').then(result => {
        result.json().then(data => {
          setReasons(data);
        })
      });
    }      
  });  
  
  return (
    <>
      <Particle params={particlesConfig} className="App-particles__container" />
      <div className="App">
        <div className="App-text">
          <h1 className="App-text__title">Berkshire Hathaway</h1>
          <h2 className="App-text__body">
            Project from Jason Witte
            <br/>
            Site credit: <a href="https://codesandbox.io/s/c0y43?file=/src/App.js:0-562">https://codesandbox.io/s/c0y43?file=/src/App.js:0-562</a>
          </h2>
          {reasons ? reasons.map(reason => <Reason reason={reason} key={reason.id}></Reason>) : <></>}
        </div>
      </div>
    </>
  );
}

export default App;
