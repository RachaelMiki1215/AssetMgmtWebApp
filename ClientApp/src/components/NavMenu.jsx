import React from 'react';
import { Box, Drawer } from '@mui/material';
import './NavMenu.css';


function NavMenu(props) {
    return(
        <Box>
            <Drawer
                variant='permanent' 
                sx={{ backgroundColor: 'fuchsia', width: 100 }}>

            </Drawer>
        </Box>
    );
}
export default NavMenu;