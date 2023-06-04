using System;

namespace Ex04.Menus.Delegates
{
    public class ExecutableMenuItem : MenuItem
    {
        public event Action ReportClick;
        public ExecutableMenuItem(string i_Title) : base(i_Title) 
        {
        }

        internal override void OnClick()
        { 
            ReportClick?.Invoke();
        }
    }
}
