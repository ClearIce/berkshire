import React, { useEffect, useState } from "react";
import Particle from "react-particles-js";
import particlesConfig from "../assets/particlesConfig.json";

function App() {
  let reasonTable = <></>;
  const [reasons, setReasons] = useState("");

  useEffect(() => {
    async function getReasons() {
      const response = await fetch('api/reasons');
      setReasons(await response.json());
    }
    getReasons();
  });
  
  if (reasons) {
    reasonTable = 
    <table className='table table-striped' aria-labelledby="tabelLabel">
      <thead>
        <tr>
          <th>Id</th>
          <th>Reason</th>
          <th>Created</th>
          <th>Updated</th>
        </tr>
      </thead>
      <tbody>
        {reasons.map(reason =>
          <tr key={reason.id}>
            <td>{reason.id}</td>
            <td>{reason.reason}</td>
            <td>{reason.created}</td>
            <td>{reason.updated}</td>
          </tr>
        )}
      </tbody>
    </table>
  }
  
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
          {reasonTable}
        </div>
      </div>
    </>
  );
}

export default App;
