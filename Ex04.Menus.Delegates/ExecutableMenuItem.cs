using System;

namespace Ex04.Menus.Delegates
{
    public class ExecutableMenuItem : MenuItem
    {
        public event Action Click;

        public ExecutableMenuItem(string i_Title) : base(i_Title) 
        {
        }

        protected virtual void OnClick()
        { 
            Click?.Invoke();
        }
    }
}
