using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class Menu : MenuItem, IClickable
    {
        protected string m_ExitWord;
        private List<MenuItem> m_subItems;
        
        public Menu(string i_Title) : base(i_Title)
        {
            m_ExitWord = "Back";
            m_subItems = new List<MenuItem>();
        }

        public void AddItemToMenu(MenuItem i_MenuItem)
        {
            m_subItems.Add(i_MenuItem);
        }

        public void RemoveItemFromMenu(MenuItem i_MenuItem)
        {
            m_subItems.Remove(i_MenuItem);
        }

        public void Show()
        {
            bool stillRunning = true;

            while (stillRunning)
            {
                showMenuTitle();
                displayAllOptionsInMenu();
                int userChoice = getUserChoice();
                if (userChoice != 0)
                {
                    MenuItem subItem = m_subItems[userChoice - 1];
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
            while (!isValidInput || userChoice < 0 || userChoice > m_subItems.Count)
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
            foreach (MenuItem subItem in m_subItems)
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
