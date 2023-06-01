﻿using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class MainMenu: Menu
    {
        public MainMenu(string i_Title): base(i_Title)
        {
            m_ExitWord = "Exit";
        }
    }
}
