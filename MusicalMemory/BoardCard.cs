using System;
using System.Drawing;
using System.Windows.Forms;
using GameLogic;

namespace MusicalMemory
{
    public class BoardCard
    {
        #region Private Class Members
        // settings of backgreound image and size of button
        private readonly int SIZE = 73;
        private readonly Image backround = Properties.Resources.MusicNoteImage;

        // Class members
        private Button m_Button;
        private MusicCard m_Card;
        private Point m_Location;

        #endregion Private Class Members

        #region Public Class Members
        // EventHandler to handle button clicks, invoked when button is clicked
        public EventHandler ButtonWasClicked;
        #endregion Public Class Members

        #region Constructor
        public BoardCard()
        {
            m_Button = new Button();
            setButtonSettings();
            SetCard("");                                 
            SetLocation(new Point(0,0));
        }
        #endregion Constructor

        #region Properties
        public Button BoardButton
        {
            get { return m_Button; }
        }

        public MusicCard Card
        {
            get { return this.m_Card; }
            set { m_Card = value; }
        }
        #endregion Properties

        #region Public Methods

        public void SetLocation(Point i_Point)
        {
            m_Button.Location = i_Point;
            m_Location = i_Point;
        }

        public void SetCard(string i_Name)
        {
            m_Card = new MusicCard(i_Name);
        }

        /// <summary>
        ///     This method represents the logical flip of the m_Card class member.
        ///     The sender is m_Button, and this method handles the graphic change of that button, 
        ///     which represents th UI side of the flip of the m_Card.
        ///     
        ///     If the card is up-side-down, this method will flip it and play the attached music.
        ///     If the card is down-side-up, this method will flip it and stop the attached music.
        /// </summary>
        /// <param name="sender">BoardButton</param>
        /// <param name="e"></param>
        internal void playCard(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            // Flip the card
            m_Card.Turn();

            // Card is now down-side-up
            if (m_Card.IsShowing)
            {
                m_Button.BackgroundImage = null;
                if (m_Card.Type == Enums.eCardType.SINGER)
                {
                    button.Text = m_Card.Text;
                }
                else button.Text = m_Card.SongName.ToString();
                m_Card.Play();

            }
            // Card is now up-side-down
            else
            {
                m_Button.BackgroundImage = backround;
                button.Text = "";
                m_Card.Stop();
            }
            ButtonWasClicked.Invoke(this, e);
        }

        /// <summary>
        ///     This method forces the Card class member to be up-side-down
        /// </summary>
        public void Hide()
        {
            if (m_Card.IsShowing)
            {
                m_Card.Turn();
            }
            m_Button.BackgroundImage = backround;
            BoardButton.Text = "";
            m_Card.Stop();
        }
        #endregion Public Methods

        #region Private Methods
        private void setButtonSettings()
        {
            m_Button.Width = SIZE;
            m_Button.Height = SIZE;
            m_Button.Click += new EventHandler(playCard);
            m_Button.BackgroundImage = backround;
            m_Button.BackgroundImageLayout = ImageLayout.Stretch;
        }
        #endregion Private Methods

    }
}
