using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Michaeljeon_GAME_ASSESSMENT
{
    public partial class Form1 : Form
    {
        string playerName;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            playerName = txtName.Text;
            GameForm Form1 = new GameForm();
            Hide();
            Form1.ShowDialog();
        }
    }
}
