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
    public partial class frmBossBlueEyesWhiteDragon : Form
    {
        public frmBossBlueEyesWhiteDragon()
        {
            InitializeComponent();
        }

        private void btnOptionOne_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The blue eyes white dragon turns the cake into cinders! It had no effect...");
        }

        private void btnOptionThree_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ha! You activated your trap card and destroyed the blue eyes white dragon! You earned find an Emerald where Blue Eyes White Dragon was destryed!");
            GlobalBoss.score = GlobalBoss.score + 10;
            GlobalBoss.blueEyesDefeated = true;
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Blue eyes white dragon stares at the eye before destroying it with Burst Stream of Destruction! The eye had no effect...");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Blue eyes white dragon over powers the attack! it had no effect...");
        }

        private void btnOptionTwo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The attack bounced off against blue eyes white dragon's scales! It ahd no effect...");
        }
    }
}
