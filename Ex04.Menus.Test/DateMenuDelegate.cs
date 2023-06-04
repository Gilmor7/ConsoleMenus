using Ex04.Menus.Delegates;
using System;

namespace Ex04.Menus.Test
{
    public class DateMenuDelegate
    {
        private Menu m_DateTimeMenu;

        public Menu DateTimeMenu
        {
            get
            {
                return m_DateTimeMenu;
            }
        }

        public DateMenuDelegate()
        {
            Menu dataTimeMenu = new Menu("** Show Date/Time **");
            ExecutableMenuItem dateOption = new ExecutableMenuItem("Show Date");
            ExecutableMenuItem timeOption = new ExecutableMenuItem("Show Time");

            dateOption.ReportClick += showData_Clicked;
            timeOption.ReportClick += showTime_Clicked;
            
            dataTimeMenu.AddItemToMenu(dateOption);
            dataTimeMenu.AddItemToMenu(timeOption);

            m_DateTimeMenu = dataTimeMenu;
        }

        private void showData_Clicked()
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("Current date is: {0:dd/MM/yyyy}", dateTime);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private void showTime_Clicked()
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("The current time is: {0:HH:mm:ss}", dateTime);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
    
}
