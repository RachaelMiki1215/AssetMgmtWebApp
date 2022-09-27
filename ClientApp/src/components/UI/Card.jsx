import React from "react";

import styles from "./Card.module.scss";

const Card = (props) => {
  return (
    <div
      id={props.id}
      className={`${styles.card} ${styles[props.theme]} ${props.className}`}
      style={props.style}
      onClick={props.onClick}
    >
      {props.children}
    </div>
  );
};
Card.displayName = Card.name;

export default Card;
