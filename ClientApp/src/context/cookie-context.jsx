import React, { createContext } from "react";
import { CookiesProvider, useCookies } from "react-cookie";

const CookieContext = createContext({
  cookies: {},
  setCookie: () => {},
  removeCookie: () => {},
});

const CookieContextProvider = (props) => {
  const [cookies, setCookie, removeCookie] = useCookies(["user"]);

  return (
    <CookiesProvider>
      <CookieContext.Provider
        value={{
          cookies: cookies,
          setCookie: setCookie,
          removeCookie: removeCookie,
        }}
      >
        {props.children}
      </CookieContext.Provider>
    </CookiesProvider>
  );
};
CookieContextProvider.displayName = CookieContextProvider.name;

export default CookieContext;
export { CookieContextProvider };
