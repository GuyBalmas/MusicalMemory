
namespace GameLogic
{
    public class Card
    {
        private string m_Text;
        private int m_ID;
        private bool m_IsShowing;

        public Card()
        {
            ID = -1;
            m_IsShowing = false;
            m_Text = "";
        }

        public int ID {
            get { return m_ID; }
            set { m_ID = value; }
        }

        public string Text
        {
            get { return m_Text; }
            set { m_Text = value; }
        }

        public bool IsShowing
        {
            get { return m_IsShowing; }
        }

        public void Turn()
        {
            m_IsShowing = !m_IsShowing;
        }     
    }
}
