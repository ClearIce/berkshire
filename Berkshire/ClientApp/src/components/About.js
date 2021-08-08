import React from "react";
import "../assets/about.css";

function About() {
  return (
    <div className="App">
      <div className="App-text about">
        <div className="about-text__title">
          Hello, I'm{" "}
          <span className="about-text__title-big">Jason Witte</span>.
        </div>
        <div className="about-text__title">
          I'm looking for work
        </div>
        <div className="about-text__body">
          I'm a self-taught full stack web developer
        </div>
        <div className="about-text__body">
          My main skills are:
          <ul>
            <li>C#/.NET</li>
            <li>ASP.NET Core 5+</li>
            <li>React</li>
            <li>MSSQL</li>
            <li>Azure Cloud/DevOps</li>
            <li>Jira/Confluence</li>
            <li>Git</li>          
            <li>Sitecore 9.0/9.1/9.3</li>
            <li>Sitecore 9.1 with SXA</li>
          </ul>
        </div>
        <div className="about-text__body">
          I have these certifications:
          <ul>
            <li>OSCP</li>
            <li>Sitecore 9.0</li>
          </ul>
        </div>
        <div className="about-social">          
          <div className="about-social__links">
            <a
              className="about-social__link"
              href="https://github.com/clearice"
              rel="noopener noreferrer"
              target="_blank">
              github
            </a>            
            <a
              className="about-social__link"
              href="mailto:jason.witte.uab@gmail.com"
              rel="noopener noreferrer"
              target="_blank">
              email
            </a>
          </div>
        </div>
      </div>
    </div>
  );
}

export default About;
