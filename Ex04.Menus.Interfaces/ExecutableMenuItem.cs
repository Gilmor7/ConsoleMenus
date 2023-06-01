using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class ExecutableMenuItem : MenuItem, IClickable
    {
        private readonly List<IClickObserver> r_ExecutableMenuItemListeners;

        public ExecutableMenuItem(string i_Title): base(i_Title)
        {
            r_ExecutableMenuItemListeners = new List<IClickObserver>();
        }

        public void OnClick()
        {
            foreach (IClickObserver observer in r_ExecutableMenuItemListeners)
            {
                observer.executableItem_Click();
            }
        }

        public void AddListener(IClickObserver i_Listener)
        {
            r_ExecutableMenuItemListeners.Add(i_Listener);
        }

        public void RemoveListener(IClickObserver i_Listener)
        {
            r_ExecutableMenuItemListeners.Remove(i_Listener);
        }
    }
}
