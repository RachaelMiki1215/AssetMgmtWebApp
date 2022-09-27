import React from "react";
import { NavLink } from "react-router-dom";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import {
  faDoorOpen,
  faFlask,
  faPeopleGroup,
  faRectangleList,
  faTableColumns,
  faToolbox,
  faGear,
} from "@fortawesome/free-solid-svg-icons";

import styles from "./NavMenu.module.scss";

const NavMenu = (props) => {
  return (
    <div className={`${styles.navmenu} ${styles[props.theme]}`}>
      <NavMenuUserDisplay userFirstName="TestUser" theme={props.theme} />
      <nav>
        <NavItem
          icon={faTableColumns}
          theme={props.theme}
          link="/dashboard"
          text="My Dashboard"
        />
        <NavItem
          icon={faToolbox}
          theme={props.theme}
          link="/equipment"
          text="Equipment"
        />
        <NavItem
          icon={faPeopleGroup}
          theme={props.theme}
          link="/teams"
          text="Teams"
        />
        <NavItem
          icon={faFlask}
          theme={props.theme}
          link="/labs-envs"
          text="Labs &amp; Environments"
        />
        <NavItem
          icon={faRectangleList}
          theme={props.theme}
          link="/qna"
          text="Q&amp;A"
        />
      </nav>
      <NavItem
        className={styles.logout}
        icon={faDoorOpen}
        theme={props.theme}
        link="/logout"
        text="Log Out"
      />
    </div>
  );
};
NavMenu.displayName = NavMenu.name;

const NavItem = (props) => {
  return (
    <NavLink
      className={`${styles["nav-item"]} ${props.className}`}
      to={props.link}
    >
      <FontAwesomeIcon
        icon={props.icon}
        className={`${styles.icon} ${styles[props.theme]}`}
      />
      <div className={`${styles.text} ${styles[props.theme]}`}>
        {props.text}
      </div>
    </NavLink>
  );
};
NavItem.displayName = NavItem.name;

const NavMenuUserDisplay = (props) => {
  const greeting = () => {
    const current = new Date().getHours();

    if (current > 3 && current < 13) {
      return "Good morning";
    }
    if (current > 12 && current < 17) {
      return "Good afternoon";
    }
    if (current > 16 && current < 21) {
      return "Good evening";
    }
    return "Hello";
  };

  return (
    <div className={styles["nav-menu-user-display"]}>
      <NavLink className={styles["user-icon"]} to="/user">
        <img src={props.userImg} className={styles["user-img"]} />
        <FontAwesomeIcon
          icon={faGear}
          className={`${styles["gear-overlay"]} ${styles[props.theme]}`}
        />
      </NavLink>
      <div className={styles.greeting}>
        <span className={`${styles["greeting-word"]} ${styles[props.theme]}`}>
          {greeting()}
        </span>
        <span className={`${styles["user-name"]} ${styles[props.theme]}`}>
          {props.userFirstName}
        </span>
      </div>
    </div>
  );
};
NavMenuUserDisplay.displayName = NavMenuUserDisplay.name;

export default NavMenu;
export { NavItem, NavMenuUserDisplay };
