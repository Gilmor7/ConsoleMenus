using Ex04.Menus.Interfaces;
using System;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            MainMenu myMainMenu = new MainMenu("My Main");
            myMainMenu.Show();
        }
    }
}
