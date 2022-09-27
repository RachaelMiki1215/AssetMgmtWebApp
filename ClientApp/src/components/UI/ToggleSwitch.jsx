import React from "react";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faMoon, faSun } from "@fortawesome/free-solid-svg-icons";

import styles from "./ToggleSwitch.module.scss";

const ToggleSwitch = (props) => {
  return (
    <div className={`${styles["toggle-switch"]} ${props.className}`}>
      <input
        type="checkbox"
        className={styles.checkbox}
        id={props.id}
        onChange={props.onChange}
        defaultChecked={props.defaultChecked}
      />
      <label className={styles["inner-area"]} htmlFor={props.id}>
        <div className={styles["bg-color-container"]}>
          <div style={{ backgroundColor: `${props.colorOn}` }} />
          <div
            style={{
              background: `linear-gradient(to right, ${props.colorOn}, ${props.colorOff})`,
            }}
          />
          <div style={{ backgroundColor: `${props.colorOff}` }} />
        </div>
        <div className={styles["inner-labels"]}>
          <label className={`${styles.text} ${styles.on}`}>
            {props.contentOn}
          </label>
          <label className={`${styles.text} ${styles.off}`}>
            {props.contentOff}
          </label>
        </div>
        <span className={`${styles.switch} ${styles[props.theme]}`} />
      </label>
    </div>
  );
};
ToggleSwitch.displayName = ToggleSwitch.name;

const ThemeToggleSwitch = (props) => {
  return (
    <ToggleSwitch
      contentOn={<FontAwesomeIcon icon={faSun} style={{color: 'gold'}} />}
      contentOff={<FontAwesomeIcon icon={faMoon} style={{color: 'gold'}} />}
      id={props.id}
      onChange={props.onChange}
      defaultChecked={props.defaultChecked}
      theme={props.theme}
      className={props.className}
      colorOn='#82B2E8'
      colorOff='#0c1445'
    />
  );
};
ThemeToggleSwitch.displayName = ThemeToggleSwitch.name;

export default ToggleSwitch;
export { ThemeToggleSwitch };
