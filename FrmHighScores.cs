using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Michaeljeon_GAME_ASSESSMENT
{
    public partial class FrmHighScores : Form
    {
        string binPath = Application.StartupPath + @"\highscores.txt";

        public FrmHighScores(string playerName, string playerScore)
        {
            InitializeComponent();
            // get name and score from frmGame and show in lblPlayerName and lblPlayerScore         
            lblPlayerName.Text = playerName;
            lblPlayerScore.Text = playerScore;

            var reader = new StreamReader(binPath);

            // While the reader still has something to read, this code will execute.
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
            }
        }



        private void btnReturn_Click(object sender, EventArgs e)
        {
            FrmHighScores FrmHighScore2 = new FrmHighScores(label1.Text,label2.Text);




            Hide();
            FrmHighScore2.ShowDialog();



        }

        private void FrmHighScores_Load(object sender, EventArgs e)
        {

        }
    }
}
