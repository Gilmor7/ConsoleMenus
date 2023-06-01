using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class Menu : MenuItem, IClickable
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
                int userChoice = getUserChoice();

                showMenuTitle();
                displayAllOptionsInMenu();
                if (userChoice != 0)
                {
                    MenuItem subItem = r_SubItems[userChoice - 1];
                    (subItem as IClickable).OnClick();
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
            
            Console.WriteLine(Title);
            for (int i = 0; i < titleLen; i++)
            {
                Console.Write("=");
            }
            
            Console.WriteLine();
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

        public void OnClick()
        {
            Show();
        }
    }
}
