import React from "react";

import styles from "./Background.module.scss";

const Background = (props) => {
  return (
    <div
      id={props.id}
      className={`${styles.background} ${styles[props.theme]}`}
      onClick={props.onClick}
    >
      {props.children}
    </div>
  );
};
Background.displayName = Background.name;

export default Background;
