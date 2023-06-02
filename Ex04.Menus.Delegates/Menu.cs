using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex02.ConsoleUtils;

namespace Ex04.Menus.Delegates
{
    public class Menu : MenuItem
    {
        protected string m_ExitWord;
        private readonly List<MenuItem> r_SubItems;

        public Menu(string i_Title) : base(i_Title)
        {
            m_ExitWord = "Back";
            r_SubItems = new List<MenuItem>();
        }

        public void AddItemToMenu(MenuItem i_MenuItem)
        {
            r_SubItems.Add(i_MenuItem);
        }

        public void RemoveItemFromMenu(MenuItem i_MenuItem)
        {
            r_SubItems.Remove(i_MenuItem);
        }

        public void Show()
        {
            bool stillRunning = true;

            while (stillRunning)
            {
                Screen.Clear();
                showMenuTitle();
                displayAllOptionsInMenu();
                
                int userChoice = getUserChoice();
                
                if (userChoice != 0)
                {
                    MenuItem subItem = r_SubItems[userChoice - 1];
                    subItem.OnClick();
                }
                else
                {
                    stillRunning = false;
                }
            }
        }

        private void showMenuTitle()
        {
            int titleLen = Title.Length;
            StringBuilder divider = new StringBuilder();
            
            Console.WriteLine(Title);
            for (int i = 0; i < titleLen; i++)
            {
                divider.Append("=");
            }
            
            Console.WriteLine(divider.ToString());
        }

        private int getUserChoice()
        {
            string userChoiceStr = Console.ReadLine();
            bool isValidInput = int.TryParse(userChoiceStr, out int userChoice);
            while (!isValidInput || userChoice < 0 || userChoice > r_SubItems.Count)
            {
                Console.WriteLine("Invalid input, please try again");
                userChoiceStr = Console.ReadLine();
                isValidInput = int.TryParse(userChoiceStr, out userChoice);
            }
            return userChoice;
        }

        private void displayAllOptionsInMenu()
        {
            int i = 1;

            foreach (MenuItem subItem in r_SubItems)
            {
                Console.WriteLine($"{i}. {subItem.Title}");
                i++;
            }

            Console.WriteLine($"0. {m_ExitWord}");
        }

        internal override void OnClick()
        {
            Show();
        }
    }
}
