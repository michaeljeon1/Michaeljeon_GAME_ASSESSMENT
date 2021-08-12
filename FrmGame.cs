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
        public partial class FrmGame : Form
        {
            public FrmGame()
            {
                InitializeComponent();
            TxtName.Text = Form1.playerName;

            TxtScore.Text = GameForm.score.ToString();
            }

            private void FrmGame_Load(object sender, EventArgs e)
            {

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void BtnQuit_Click(object sender, EventArgs e)
            {
                Application.Exit();

            }

            private void BtnCheck_Click(object sender, EventArgs e)
            {
                FrmHighScores FrmHighScore2 = new FrmHighScores(TxtName.Text, TxtScore.Text);

                Hide();
                FrmHighScore2.ShowDialog();

            }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCheck_Click_1(object sender, EventArgs e)
        {
            FrmHighScores FrmHighScores3 = new FrmHighScores(TxtName.Text, TxtScore.Text);
            Hide();
            FrmHighScores3.ShowDialog();
        }
    }
    }
