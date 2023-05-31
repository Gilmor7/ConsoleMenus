using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class ExecutableMenuItem : MenuItem, IClickable
    {

        private List<IClickObserver> m_ExecutableMenuItemListeaners;

        public ExecutableMenuItem(string i_Title): base(i_Title)
        {
            m_ExecutableMenuItemListeaners = new List<IClickObserver>();
        }

        public void OnClick()
        {
            foreach (IClickObserver observer in m_ExecutableMenuItemListeaners)
            {
                observer.executableItem_Click();
            }
        }

        public void AddListener(IClickObserver i_Listener)
        {
            m_ExecutableMenuItemListeaners.Add(i_Listener);
        }

        public void RemoveListener(IClickObserver i_Listener)
        {
            m_ExecutableMenuItemListeaners.Remove(i_Listener);
        }
    }
}
