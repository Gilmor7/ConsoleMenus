using Ex04.Menus.Interfaces;
using System;
using System.Linq;

namespace Ex04.Menus.Test
{
    public class VersionMenuInterface
    {
        private Menu m_VersionSpacesMenu;

        public Menu VersionSpacesMenu
        {
            get
            {
                return m_VersionSpacesMenu;
            }
        }

        public VersionMenuInterface()
        {
            Menu versionSpacesMenu = new Menu("** Version and Spaces **");
            ExecutableMenuItem versionOption = new ExecutableMenuItem("Show Version");
            ExecutableMenuItem spacesOption = new ExecutableMenuItem("Count Spaces");

            versionOption.AddListener(new ShowVersion());
            spacesOption.AddListener(new CountSpaces());
            versionSpacesMenu.AddItemToMenu(versionOption);
            versionSpacesMenu.AddItemToMenu(spacesOption);

            m_VersionSpacesMenu = versionSpacesMenu;
        }

        private class ShowVersion : IClickObserver
        {
            private string m_CurrVersion = "Version: 23.2.4.9805";
            
            public void executableItem_Click()
            {
                Console.WriteLine(m_CurrVersion);
            }
        }

        private class CountSpaces : IClickObserver
        {
            public void executableItem_Click()
            {
                int numOfSpaces;
                string userSentence;
                
                Console.WriteLine("Enter a sentence:");
                userSentence = Console.ReadLine();
                numOfSpaces = countSpaces(userSentence);
                
                Console.WriteLine("The number of spaces in the sentence is: {0}", numOfSpaces);
            }

            private int countSpaces(string i_UserInput)
            {
                int numOfSpaces = 0;
                
                foreach (char currChar in i_UserInput)
                {
                    if (currChar == ' ')
                    {
                        numOfSpaces++;
                    }
                }

                return numOfSpaces;
            }
        }
    }
}
