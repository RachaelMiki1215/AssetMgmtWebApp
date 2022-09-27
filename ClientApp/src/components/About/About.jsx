import React from "react";

import { CardModal } from "../UI/Modal";
import { RoundIconButton } from "../UI/Button";

import styles from "./About.module.scss";
import { faXmark } from "@fortawesome/free-solid-svg-icons";

const About = (props) => {
  return (
    <CardModal theme={props.theme} className={styles.about} onOverlayClick={props.onConfirm}>
      <h1>About</h1>
      <p>This web app is an example of an asset management application.</p>
      <dl className={styles["params-dict"]}>
        <dt>Version</dt>
        <dd>0.1</dd>
        <dt>Author</dt>
        <dd>Rachael Buxton</dd>
      </dl>
      <RoundIconButton
        icon={faXmark}
        className={styles["exit-button"]}
        theme={props.theme}
        onClick={props.onConfirm}
      />
    </CardModal>
  );
};
About.displayName = About.name;

export default About;
