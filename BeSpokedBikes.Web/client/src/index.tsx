import React from "react";
import * as serviceWorker from "./serviceWorker";

import ReactDOM from "react-dom";
import { BrowserRouter, Router } from "react-router-dom";
import { createBrowserHistory } from "history";
import StyledEngineProvider from "@material-ui/core/StyledEngineProvider";
import "mobx-react/batchingForReactDom";
import App from "./App";

ReactDOM.render(
  <BrowserRouter basename="/">
    <StyledEngineProvider injectFirst>
      <App />     
    </StyledEngineProvider> 
  </BrowserRouter>,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
serviceWorker.unregister();

