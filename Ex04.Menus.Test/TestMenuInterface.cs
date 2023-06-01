using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class TestMenuInterface
    {
        private MainMenu m_InterfaceMainMenu;

        public TestMenuInterface()
        {
            m_InterfaceMainMenu = new MainMenu("Interface Main Menu!");
            DateMenuInterface dataTimeInterfaceMenu = new DateMenuInterface();
            VersionMenuInterface versionSpacesMenu = new VersionMenuInterface();
            m_InterfaceMainMenu.AddItemToMenu(dataTimeInterfaceMenu.DateTimeMenu);
            m_InterfaceMainMenu.AddItemToMenu(versionSpacesMenu.VersionSpacesMenu);
        }

        public void Show()
        {
            m_InterfaceMainMenu.Show();
        }
    }
}
