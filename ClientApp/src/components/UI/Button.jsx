import React from "react";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";

import styles from "./Button.module.scss";

const IconButton = (props) => {
  return (
    <button
      className={`${styles.button} ${props.className}`}
      onClick={props.onClick}
      id={props.id}
      type={props.type}
    >
      <FontAwesomeIcon
        icon={props.icon}
        className={`${styles.icon} ${styles[props.theme]}`}
      />
    </button>
  );
};
IconButton.displayName = IconButton.name;

const RoundIconButton = (props) => {
  return (
    <button
      className={`${styles["round-button"]} ${styles[props.theme]} ${
        props.className
      }`}
      onClick={props.onClick}
      id={props.id}
      type={props.type}
    >
      <FontAwesomeIcon
        icon={props.icon}
        className={`${styles.icon} ${styles[props.theme]}`}
      />
    </button>
  );
};
RoundIconButton.displayName = RoundIconButton.name;

export { IconButton, RoundIconButton };
