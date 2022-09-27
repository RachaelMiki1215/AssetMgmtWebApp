import React from "react";

import styles from './DropDown.module.scss';

const DropDown = (props) => {
  return (
    <select name={props.name} id={props.id} style={`${styles.select}`}>
      {props.options.map((option) => {
        <option value={option.toLoowerCase()}>{option}</option>;
      })}
    </select>
  );
};
DropDown.displayName = DropDown.name;

export { DropDown };
