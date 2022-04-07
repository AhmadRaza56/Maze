using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze.Boss_interactions
{
    public partial class frmBossKirby : Form
    {
        public frmBossKirby()
        {
            InitializeComponent();
        }

        public void btnOptionOne_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kirby appreciates the cake and gives you a diamond as thanks!");
            GlobalBoss.kirbyDefeated = true;
            GlobalBoss.score = GlobalBoss.score + 6;
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kirby stares at the eye before sucking it down! It had no effect...");
        }

        private void btnOptionThree_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kirby slices the trap card in half! It had no effect...");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kirby dodged the attack! It had no effect...");
        }

        private void btnOptionTwo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kirby counters with his own sword beam! It had no effect...");
        }
    }
}
