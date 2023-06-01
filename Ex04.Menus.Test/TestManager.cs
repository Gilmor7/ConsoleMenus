namespace Ex04.Menus.Test
{
    public class TestManager
    {
        private TestMenuInterface m_InterfaceMainMenu;
        private TestMenuDelegate m_DelegateMainMenu;

        public TestManager()
        {
            m_InterfaceMainMenu = new TestMenuInterface();
            m_DelegateMainMenu = new TestMenuDelegate();
        }

        public void Run()
        {
            m_InterfaceMainMenu.Show();
            m_DelegateMainMenu.Show();
        }
    }
}
