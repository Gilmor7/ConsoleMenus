using Ex04.Menus.Interfaces;
using System;

namespace Ex04.Menus.Test
{
    public class DateMenuInterface
    {
        private Menu m_DateTimeMenu;
        
        public Menu DateTimeMenu
        {
            get
            {
                return m_DateTimeMenu;
            }
        }

        public DateMenuInterface()
        {
            Menu dateTimeMenu = new Menu("** Show Date/Time **");
            ExecutableMenuItem dateOption = new ExecutableMenuItem("Show Date");
            ExecutableMenuItem timeOption = new ExecutableMenuItem("Show Time");
            
            dateOption.AddListener(new ShowData());
            timeOption.AddListener(new ShowTime());
            dateTimeMenu.AddItemToMenu(dateOption);
            dateTimeMenu.AddItemToMenu(timeOption);

            m_DateTimeMenu = dateTimeMenu;
        }

        private class ShowData : IClickObserver
        {
            public void executableItem_Click()
            {
                DateTime dateTime = DateTime.Now;
                Console.WriteLine("Current date is: {0:dd/MM/yyyy}", dateTime);
            }
        }
        
        private class ShowTime : IClickObserver
        {
            public void executableItem_Click()
            {
                DateTime dateTime = DateTime.Now;
                Console.WriteLine("The current time is: {0:HH:mm:ss}", dateTime);
            }
        }
    }
}
