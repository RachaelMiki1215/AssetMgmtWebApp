import React from "react";
import { useState } from "react";
import { useEffect } from "react";

import styles from "./Table.module.scss";

const Table = (props) => {
    const [tblKeys, setTblKeys] = useState([]);

  useEffect(() => {
    setTblKeys(Object.keys(props.data[0]));

    return () => {
        console.log(tblKeys);
    };
  }, [props.data]);

  return (
    <table
      className={`${styles.table} ${styles[props.theme]} ${props.className}`}
    >
      <thead>
        <tr>
            {tblKeys && tblKeys.filter(item => item !== 'category').map(item => <th key={item}>{item}</th>)}
        </tr>
      </thead>
      <tbody></tbody>
    </table>
  );
};
Table.displayName = Table.name;

export default Table;
