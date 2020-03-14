using GameLogic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static GameLogic.Enums;

namespace MusicalMemory
{
    // This Form represents a Musical Memory pairing game
    public partial class GameForm : Form
    {
        #region Private Class Members
        // Fixed Size Board
        private readonly int ROWS = 4;
        private readonly int COLUMNS = 4;
        private readonly Color player1Color = Color.DarkRed;
        private readonly Color player2Color = Color.Magenta;
        private readonly Color colorSelected = Color.Gold;
        private readonly Color colorDefault = Color.LightBlue;
        private readonly string[] m_Songs = new string[] {
            "Lose Yourself",
            "Smooth Criminal",
            "Dance Monkey",
            "Old Town Road",
            "פאוץ",
            "קומסי קומסה",
            "Believer",
            "7 Rings",
            "Bad Guy",
            "Human",
            "Mirrors",
            "Panda",
            "In The End",
            "Is This Love",
            "Freestyler",
            "Scatman"
        };
        private readonly string[] m_Singers = new string[] {
            "Eminem",
            "Michael Jackson",
            "Tones and I",
            "Lil Nas X",
            "נועה קירל",
            "סטפן לגר",
            "Imagine Dragons",
            "Ariana Grande",
            "Billie Eilish",
            "Rag'n'Bone Man",
            "Justin Timberlake",
            "Desiigner",
            "Linkin Park",
            "Bob Marley",
            "Bomfunk MC's",
            "Scatman John"
        };

        
        private List<BoardCard> m_SongCards;
        private List<BoardCard> m_SingerCards;
        private List<BoardCard> m_Pairs;
        private BoardCard songChoice;
        private BoardCard singerChoice;
        Player player1;
        Player player2;
        private Player nowPlaying;
        private int songIndex = 0;
        private string currentArtist = "";
        #endregion Private Class Members

        #region Constructor
        public GameForm()
        {
            InitializeComponent();
            m_SongCards = new List<BoardCard>();
            m_SingerCards = new List<BoardCard>();
            m_Pairs = new List<BoardCard>();
            addBoardButtons();
            CardsPanel2.Enabled = false;
            run();
        }
        #endregion Constructor

        #region Public Methods
        public void SetPlayers(string player1Name, string player2Name)
        {
            player1 = new Player(player1Name);
            player2 = new Player(player2Name);
            nowPlaying = player1;
            updateGraphics();
        }
        #endregion Public Methods

        #region Private Methods
        private void gameEnded()
        {
            Player winner;
            StringBuilder sb = new StringBuilder();
            updateGraphics();
            if(player1.Score == player2.Score)
            {
                sb.AppendLine("Tie! Both " + player1.Name + " and " + player2.Name + " has " + player1.Score + " points");
                sb.AppendLine("Play another game?");
            }
            else
            {
                winner = (player1.Score > player2.Score) ? player1 : player2;
                sb.AppendLine(winner.Name + " has won! with " + winner.Score + " points");
                sb.AppendLine("Play another game?");
            }
            
            DialogResult result = MessageBox.Show(
                sb.ToString(),
                "Game Over!",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                resetGame();
            }
            else
            {
                Application.Exit();
            }
                
        }

        private void resetGame()
        {
            player1.Score = 0;
            player2.Score = 0;
            CardsPanel1.Controls.Clear();
            CardsPanel2.Controls.Clear();
            m_SongCards = new List<BoardCard>();
            m_SingerCards = new List<BoardCard>();
            m_Pairs = new List<BoardCard>();
            songChoice = null;
            singerChoice = null;
            addBoardButtons();
            run();
        }

        private void run()
        {
            updateGraphics();
        }

        private void updateGraphics()
        {
            if (player1 != null && player2 != null && nowPlaying != null)
            {
                Lable_Player1.Text = "Player1 : " + player1.Name;
                Lable_Player2.Text = "Player2 : " + player2.Name;
                Lable_Player1Score.Text = "Score: " + player1.Score.ToString();
                Lable_Player2Score.Text = "Score: " + player2.Score.ToString();
                if (nowPlaying.Name == player1.Name)
                {
                    Lable_Player1.ForeColor = player1Color;
                    Lable_Player2.ForeColor = Color.Black;
                }
                else
                {
                    Lable_Player1.ForeColor = Color.Black;
                    Lable_Player2.ForeColor = player2Color;
                }
            }
            
        }

        private void addBoardButtons()
        {
            int verticalSpaceing = 5;
            int horizontalSpacing = 5;
            int id = 1;
            for(int i = 0; i < ROWS; i++)
            {
                for(int j = 0; j < COLUMNS; j++)
                {
                    /// Insert Song Cards into Left Panel
                    BoardCard card = new BoardCard();
                    string choice = chooseSong();
                    card.SetCard(choice);                                   // Insert Song names   
                    card.Card.Type = eCardType.SONG;
                    card.SetLocation(new Point(i * card.BoardButton.Size.Width + horizontalSpacing, j * card.BoardButton.Size.Height + verticalSpaceing));
                    m_SongCards.Add(card);
                    CardsPanel1.Controls.Add(card.BoardButton);
                    card.ButtonWasClicked += new EventHandler(ButtonWasClicked);

                    /// Insert Singer Cards into Right Panel
                    BoardCard SingerCard = new BoardCard();
                    SingerCard.SetCard(choice);                             // Insert Song names 
                    SingerCard.Card.Text = currentArtist;                   // Insert Artist names
                    SingerCard.Card.Type = eCardType.SINGER;
                    SingerCard.SetLocation(new Point(i * card.BoardButton.Size.Width + horizontalSpacing, j * card.BoardButton.Size.Height + verticalSpaceing));
                    m_SingerCards.Add(SingerCard);
                    CardsPanel2.Controls.Add(SingerCard.BoardButton);
                    SingerCard.ButtonWasClicked += new EventHandler(ButtonWasClicked);

                    // Set matching ID
                    card.Card.ID = id;
                    SingerCard.Card.ID = card.Card.ID;
                    id++;

                    verticalSpaceing += 10;

                }
                horizontalSpacing += 10;
                verticalSpaceing = 5;
            }
            // Shuffles cards
            shuffle();
        }

        private void shuffle()
        {
            for (int i = 0; i < 10; i++) 
            {
                shuffleAllOnce();
            }
        }

        private void shuffleAllOnce()
        {
            Random rand = new Random();

            foreach(BoardCard card in m_SongCards)
            {
                int index = rand.Next(0, m_SongCards.Count);
                BoardCard other = m_SongCards[index];
                Point location = other.BoardButton.Location;
                other.BoardButton.Location = card.BoardButton.Location;
                card.BoardButton.Location = location;
            }

            foreach (BoardCard card in m_SingerCards)
            {
                int index = rand.Next(0, m_SingerCards.Count);
                BoardCard other = m_SingerCards[index];
                Point location = other.BoardButton.Location;
                other.BoardButton.Location = card.BoardButton.Location;
                card.BoardButton.Location = location;
            }
        }

        /// <summary>
        ///     This method is invoked whenever a button is clicked, the sender is a BoardCard object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonWasClicked(object sender, EventArgs e)
        {
            BoardCard boardCard = sender as BoardCard;
            disablePairs();

            if (boardCard.Card.Type == eCardType.SONG)
            {
                songChoice = boardCard;
                CardsPanel2.Enabled = true;
                CardsPanel1.Enabled = false;
                songChoice.BoardButton.BackColor = colorSelected;
                
            }
            else if(boardCard.Card.Type == eCardType.SINGER && songChoice != null)
            {
                singerChoice = boardCard;

                // Found a matching pair
                if (songChoice != null && singerChoice != null && songChoice.Card.ID == singerChoice.Card.ID)
                {
                    // Increase players score
                    nowPlaying.Score++;

                    // Color the matching pair of buttons with the player's color
                    Color scoringPlayerColor = (nowPlaying.Name == player1.Name) ? player1Color : player2Color;
                    songChoice.BoardButton.BackColor = scoringPlayerColor;
                    singerChoice.BoardButton.BackColor = scoringPlayerColor;
                    
                    // Add the matching pair to the already discovered collection
                    m_Pairs.Add(songChoice);
                    m_Pairs.Add(singerChoice);
                    
                    // Remove the matching pair from the collection of cards left to play with
                    m_SongCards.Remove(songChoice);
                    m_SingerCards.Remove(singerChoice);
                }

                // Not a matching pair
                else 
                {
                    singerChoice.BoardButton.UseVisualStyleBackColor = true;
                    singerChoice.BoardButton.BackColor = colorSelected; 
                    singerChoice.BoardButton.Refresh();
                    Thread.Sleep(1500);
                    HideAll();
                    changeTurns();
                    singerChoice.BoardButton.BackColor = colorDefault;
                    songChoice.BoardButton.BackColor = colorDefault;
                }

                songChoice = null;
                singerChoice = null;
                CardsPanel1.Enabled = true;
                CardsPanel2.Enabled = false;
            }

            // Detect if game has ended
            if (m_Pairs.Count >= (ROWS * COLUMNS * 2))
            {
                gameEnded();
            }
            
            // Update the name and score graphics of both players
            updateGraphics();
        }

        private void disablePairs()
        {
            foreach (BoardCard card in m_Pairs)
            {
                card.BoardButton.Enabled = false;
            }
        }

        private void HideAll()
        {
            foreach (BoardCard card in m_SongCards)
            {
                if (card != null) card.Hide();
            }
            foreach (BoardCard card in m_SingerCards)
            {
                if (card != null) card.Hide();
            }
        }
        private Player changeTurns()
        {
            if(nowPlaying != null)
            {
                nowPlaying = (nowPlaying == player1) ? player2 : player1 ;
            }
            return nowPlaying;
        }

        private string chooseSong()
        {
            if (songIndex >= m_Songs.Length) songIndex = 0;

            string choice = m_Songs[songIndex];
            currentArtist = m_Singers[songIndex];
            songIndex++;
            return choice;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        #endregion Private Methods

    }
}
