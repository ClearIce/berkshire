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
          <h1 className="App-text__title">Berkshire Hathaway Homestate Companies</h1>
          <h2 className="App-text__body">
            Project from Jason Witte            
          </h2>
        </div>
        
        <div className="App-text__reasons">
          <h1 className="App-text__title">Reasons to work for BHHC</h1>
          <ul className="App-text__body">
            {reasons ? reasons.map(reason => <Reason reason={reason} key={reason.id}></Reason>) : <></>}
          </ul>
        </div>
      </div>
    </>
  );
}

export default App;
