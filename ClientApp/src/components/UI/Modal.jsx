import React from "react";
import { createPortal } from "react-dom";

import Overlay from "./Overlay";
import Card from "./Card";

import styles from "./Modal.module.scss";

const Modal = (props) => {
  return (
    <>
      {createPortal(
        <Overlay onClick={props.onOverlayClick} />,
        document.getElementById("overlay-root")
      )}
      {createPortal(
        <>{props.children}</>,
        document.getElementById("modal-root")
      )}
    </>
  );
};
Modal.displayName = Modal.name;

const CardModal = (props) => {
  return (
    <Modal onOverlayClick={props.onOverlayClick}>
      <Card
        theme={props.theme}
        className={`${styles["card-modal"]} ${props.className}`}
      >
        {props.children}
      </Card>
    </Modal>
  );
};
CardModal.displayName = CardModal.name;

export default Modal;
export { CardModal };
