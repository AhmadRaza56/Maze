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
    public partial class frmBossDarkLink : Form
    {
        public frmBossDarkLink()
        {
            InitializeComponent();
        }

        private void btnOptionOne_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dark link looks at the cake before squashing it under his foot! It had no effect...");
        }

        private void btnOptionThree_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dark link stares at the card in confusion before stabbing it with his sword. It had no effect...");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dark link slices the eye in half and destroys it! It had no effect...");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dark link deflects the attack with his shield! It had no effect...");
        }

        private void btnOptionTwo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dark link cries out from the attack and disappears into a black smoke! You find a silver coin where he disappeared!");
            GlobalBoss.darkLinkDefeated = true;
            GlobalBoss.score = GlobalBoss.score + 2;
            this.Hide();
            
        }
    }
}
