import React from "react";

import styles from "./Overlay.module.scss";

const Overlay = (props) => {
  return <div className={styles.overlay} onClick={props.onClick} />;
};
Overlay.displayName = Overlay.name;

export default Overlay;
