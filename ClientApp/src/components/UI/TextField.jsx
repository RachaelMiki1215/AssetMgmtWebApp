import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import React from "react";
import { IconButton } from "./Button";

import styles from "./TextField.module.scss";

const TextField = (props) => {
  return (
    <input
      type="text"
      className={`${styles.textfield} ${styles[props.theme]} ${
        props.className
      }`}
      id={props.id}
      placeholder={props.placeholder}
      onChange={props.onChange}
      value={props.inputValue}
    />
  );
};
TextField.displayName = TextField.name;

const IconTextField = (props) => {
  return (
    <form
      className={`${styles["icon-textfield-container"]} ${props.className}`}
      onSubmit={props.onSubmit}
    >
      <TextField
        id={props.id}
        className={`${styles["icon-textfield-textfield"]} ${props.textFieldClassName}`}
        theme={props.theme}
        placeholder={props.placeholder}
        onChange={props.onChange}
        inputValue={props.inputValue}
      />
      <IconButton
        className={`${styles["icon-button"]} ${props.iconButtonClassName}`}
        icon={props.icon}
        theme={props.theme}
        type="submit"
      />
    </form>
  );
};
IconTextField.displayName = IconTextField.name;

export default TextField;
export { IconTextField };
