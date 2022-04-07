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
    public partial class frmBossLahabrea : Form
    {
        public frmBossLahabrea()
        {
            InitializeComponent();
        }

        private void btnOptionOne_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lahabrea stares at the cake before swatting it onto the ground! It had no effect...");
        }

        private void btnOptionThree_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lahabrea laughs at the card as he destroys it! It had no effect...");
        }

        private void btnOptionTwo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lahabrea teleports to dodge the attack! It had no effect...");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lahabrea cancels out the attack with his magic! It had no effect...");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lahabrea swears his revenge as he's sealed away in the eye! You can an emerald on the ground where he was trapped by the eye!");
            GlobalBoss.lahabreaDefeated = true;
            GlobalBoss.score = GlobalBoss.score + 10;
            this.Hide();
        }
    }
}
