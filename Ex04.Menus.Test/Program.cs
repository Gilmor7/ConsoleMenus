using Ex04.Menus.Interfaces;
using System;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            MainMenu interfaceMainMenu = new MainMenu("Interface Main Menu!");
            DateMenuInterface dataTimeInterfaceMenu = new DateMenuInterface();
            VersionMenuInterface versionSpacesMenu = new VersionMenuInterface();
            interfaceMainMenu.AddItemToMenu(dataTimeInterfaceMenu.DateTimeMenu);
            interfaceMainMenu.AddItemToMenu(versionSpacesMenu.VersionSpacesMenu);
            
            interfaceMainMenu.Show();
        }
        
    }
}
