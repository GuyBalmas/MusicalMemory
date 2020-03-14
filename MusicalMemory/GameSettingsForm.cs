using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicalMemory
{
    // This form represents a game setting form
    public partial class GameSettingsForm : Form
    {
        #region Constructor
        public GameSettingsForm()
        {
            InitializeComponent();
        }
        #endregion Constructor

        #region Private Methods
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string player1Name = TextBoxPlayer1Name.Text;
            string player2Name = TextBoxPlayer2Name.Text;

            if (string.IsNullOrEmpty(player1Name)
                || string.IsNullOrEmpty(player2Name))
            {
                popMessegeBox();
                return;
            }
            // Musical Memory pairing game form
            GameForm gameForm = new GameForm();
            // Initialize player names
            gameForm.SetPlayers(player1Name, player2Name);            
            
            while (gameForm.ShowDialog() == DialogResult.OK) ;
            
            this.Close();
        }

        private void popMessegeBox()
        {
            DialogResult result = MessageBox.Show(
                "Please enter players' names",
                "Missing names",
                MessageBoxButtons.OKCancel
                ) ;
            if (result == DialogResult.OK)
            {

            }
            else
            {
                Application.Exit();
            }
        }

        private void GameSettingsForm_Load(object sender, EventArgs e)
        {

        }
        #endregion Private Methods

    }
}
