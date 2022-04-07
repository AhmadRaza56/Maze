using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class frmEnd : Form
    {
        public frmEnd()
        {
            InitializeComponent();

            lblScore.Text = "Score: " + GlobalBoss.score;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStartUp frmStartUp = new frmStartUp();
            frmStartUp.ShowDialog();
        }
    }
}
