using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class TestMenuDelegate
    {
        private MainMenu m_DelegateMainMenu;

        public TestMenuDelegate()
        {
            m_DelegateMainMenu = new MainMenu("Delegate Main Menu!");
            DateMenuDelegate dateTimeMenu = new DateMenuDelegate();
            VersionMenuDelegate versionSpacesMenu = new VersionMenuDelegate();
            m_DelegateMainMenu.AddItemToMenu(dateTimeMenu.DateTimeMenu);
            m_DelegateMainMenu.AddItemToMenu(versionSpacesMenu.VersionSpacesMenu);
        }

        public void Show()
        {
            m_DelegateMainMenu.Show();
        }
    }
}
