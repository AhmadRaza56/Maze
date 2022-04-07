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
    public partial class frmBossHydreigon : Form
    {
        public frmBossHydreigon()
        {
            InitializeComponent();
        }

        private void btnOptionOne_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hydreigon stares at the cake before turning into ashes! It had no effect...");
        }

        private void btnOptionThree_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hydreigon looks at the card before sending it flying with his wings! It had no effect...");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hydreigon looks at the eye before blasting a dark pulse at it! It had no effect...");
        }

        private void btnOptionTwo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hydreigon dodges the attack in the sky! It had no effect...");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hydreigon cries out as he's hit by the attack and returns to the pokeball! You recieve a gold coin as reward!");
            GlobalBoss.hydreigonDefeated = true;
            GlobalBoss.score = GlobalBoss.score + 4;
            this.Hide();
        }
    }
}
