import {
  faCropSimple,
  faSearch,
  faXmark,
} from "@fortawesome/free-solid-svg-icons";
import React from "react";
import { useEffect } from "react";
import { useState } from "react";

import Modal from "../UI/Modal";
import Table from "../UI/Table";
import TextField from "../UI/TextField";
import { RoundIconButton } from "../UI/Button";

import styles from "./Search.module.scss";

const tblData = [
  {
    category: "equipment",
    id: 20,
    alias: "Samsung Galaxy S6",
    type: "phone",
    condition: "Good",
    location: "Testing Lab",
  },
  {
    category: "equipment",
    id: 100,
    alias: "Lenovo Yoga",
    type: "laptop",
    condition: "Good",
    location: null,
  },
];

const GlobalSearch = (props) => {
  const [searchText, setSearchText] = useState("");

  useEffect(() => {
    console.log(searchText);
    // TODO: Add actual search logic here.
  }, [searchText]);

  const searchChangeHandler = (event) => {
    setSearchText(event.target.value);
  };

  return (
    <Modal theme={props.theme} onOverlayClick={props.onCancel}>
      <div className={styles.container}>
        <TextField
          id="global-search-bar"
          theme={props.theme}
          className={styles.search}
          placeholder="How can I help you?"
          onChange={searchChangeHandler}
          inputValue={searchText}
        />
        {searchText && searchText.trim().length > 0 && (
          <div className={styles["tbl-area"]}>
            <Table theme={props.theme} data={tblData} className />
          </div>
        )}
      </div>
      <RoundIconButton
        onClick={props.onCancel}
        icon={faXmark}
        theme={props.theme}
        className={styles["exit-button"]}
      />
    </Modal>
  );
};
GlobalSearch.displayName = GlobalSearch.name;

export default GlobalSearch;
