namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private string m_Title;

        protected MenuItem(string i_Title)
        {
            m_Title = i_Title;
        }
        
        public string Title
        {
            get
            {
                return m_Title;
            }
            set
            {
                m_Title = value;
            }
        }
    }
}
