import React, { useState } from "react";
import { faEllipsis, faSearch } from "@fortawesome/free-solid-svg-icons";

import Background from "./Background";
import NavMenu from "./NavMenu";
import { RoundIconButton } from "./Button";
import { ThemeToggleSwitch } from "./ToggleSwitch";
import About from "../About/About";
import GlobalSearch from "../Search/Search";

import styles from "./Layout.module.scss";

const Layout = (props) => {
  const [displayAboutModal, setDisplayAboutModal] = useState(false);
  const [displaySearchModal, setDisplaySearchModal] = useState(false);

  const searchButtonHandler = () => {
    setDisplaySearchModal(true);
  };
  const searchCancelHandler = () => {
    setDisplaySearchModal(false);
  };

  // const questionButtonHandler = () => {
  //   console.log("Dummy logic");
  // };

  const aboutButtonHandler = () => {
    setDisplayAboutModal(true);
  };
  const aboutConfirmHandler = () => {
    setDisplayAboutModal(false);
  };

  return (
    <>
      {displaySearchModal && (
        <GlobalSearch theme={props.theme} onCancel={searchCancelHandler} />
      )}
      {displayAboutModal && (
        <About theme={props.theme} onConfirm={aboutConfirmHandler} />
      )}
      <Background theme={props.theme}>
        <NavMenu theme={props.theme} />
        <div className={styles.content}>{props.children}</div>
        <div className={styles.buttons}>
          <RoundIconButton
            theme={props.theme}
            icon={faSearch}
            onClick={searchButtonHandler}
          />
          {/* TODO: Eventually add help (ask) function. */}
          {/* <RoundIconButton
            theme={props.theme}
            icon={faQuestion}
            onClick={questionButtonHandler}
          /> */}
          <RoundIconButton
            theme={props.theme}
            icon={faEllipsis}
            onClick={aboutButtonHandler}
          />
        </div>
        <ThemeToggleSwitch
          name="theme-toggle-switch"
          theme={props.theme}
          className={styles["theme-toggle"]}
          id="theme-toggle"
          defaultChecked="true"
          onChange={props.onThemeSliderChange}
        />
      </Background>
    </>
  );
};
Layout.displayName = Layout.name;

export default Layout;
