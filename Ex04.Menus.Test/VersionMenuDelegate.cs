using Ex04.Menus.Delegates;
using System;

namespace Ex04.Menus.Test
{
    public class VersionMenuDelegate
    {
        private Menu m_VersionSpacesMenu;
        private const string m_Version = "Version: 23.2.4.9805";

        public Menu VersionSpacesMenu
        {
            get
            {
                return m_VersionSpacesMenu;
            }
        }

        public VersionMenuDelegate()
        {
            Menu versionSpacesMenu = new Menu("** Version and Spaces **");
            ExecutableMenuItem versionOption = new ExecutableMenuItem("Show Version");
            ExecutableMenuItem spacesOption = new ExecutableMenuItem("Count Spaces");

            versionOption.Click += versionOption_Clicked;
            spacesOption.Click += spacesOption_Clicked;
            versionSpacesMenu.AddItemToMenu(versionOption);
            versionSpacesMenu.AddItemToMenu(spacesOption);

            m_VersionSpacesMenu = versionSpacesMenu;
        }

        private void versionOption_Clicked()
        {
            Console.WriteLine(m_Version);
        }

        private void spacesOption_Clicked()
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
