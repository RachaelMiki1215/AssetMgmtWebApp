import React from "react";
import { Route, Routes, Outlet, Navigate } from "react-router";
import { useState, useContext } from "react";

import LogIn from "./components/LogIn";
import Layout from "./components/UI/Layout";

import TextField, { IconTextField } from "./components/UI/TextField";
import { faSearch } from "@fortawesome/free-solid-svg-icons";
import { IconButton } from "./components/UI/Button";
import CookieContext from "./context/cookie-context";

function App() {
  const cookieCtx = useContext(CookieContext);

  const [theme, setTheme] = useState("light");

  const themeChangeHandler = () => {
    setTheme((prevTheme) => {
      return prevTheme === "light" ? "dark" : "light";
    });
  };

  return (
    <>
      {/* TODO: Add fading transition between routes/pages. */}
      {/* TODO: Need to make auth logic more complex. */}
      <Routes>
        <Route index path='/' element={cookieCtx.cookies.user ? <Navigate replace={true} to='/dashboard' /> : <Navigate replace={true} to='/login' />} />
        <Route path="login" element={cookieCtx.cookies.user ? <Navigate replace={true} to='/dashboard' /> : <LogIn />} />
        <Route path="logout" element={cookieCtx.cookies.user ? <Navigate replace={true} to='/dashboard' /> : 'Logged Out'} />
        <Route
          element={
            <Layout theme={theme} onThemeSliderChange={themeChangeHandler}>
              <Outlet />
            </Layout>
          }
        >
          <Route
            path='dashboard'
            element={cookieCtx.cookies.user ? 'Dashboard' : <Navigate replace={true} to='/login' />}
          />
          <Route path='equipment' element={cookieCtx.cookies.user ? 'Equipment' : <Navigate replace={true} to='/login' />} />
          <Route path='teams' element={cookieCtx.cookies.user ? 'Teams' : <Navigate replace={true} to='/login' />} />
          <Route path='labs-envs' element={cookieCtx.cookies.user ? 'Labs & Environments' : <Navigate replace={true} to='/login' />} />
          <Route path='qna' element={cookieCtx.cookies.user ? 'Q&A' : <Navigate replace={true} to='/login' />} />
          <Route path='user' element={cookieCtx.cookies.user ? 'User Settings' : <Navigate replace={true} to='/login' />} />
        </Route>
        <Route path='*' element={<span>404 Not Found!</span>} />
      </Routes>
    </>
  );
}
App.displayName = App.name;

export default App;
