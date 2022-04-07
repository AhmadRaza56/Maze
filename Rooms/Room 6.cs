using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze.Rooms
{
    public partial class Room_6 : Form
    {
        public Room_6()
        {
            InitializeComponent();
            if (GlobalBoss.reset == true)
            {
                picBronze.Visible = false;
                GlobalBoss.reset = false;
            }
        }

        private void Room_6_KeyDown(object sender, KeyEventArgs e)
        {
            if (GlobalBoss.darkLinkDefeated == true)
            {
                picDarkLinkBoss.Visible = false;
                lblEast.Visible = true;
                lblNorth.Visible = true;
                lblSouth.Visible = true;
                lblWest.Visible = true;

                if (playerImage.Bounds.IntersectsWith(lblEast.Bounds))
                {
                    MessageBox.Show("This path is blocked! Find a different path");
                    if (playerImage.Left > (lblEast.Width - 60))
                    {
                        playerImage.Left -= 40;
                    }
                }
                else if (playerImage.Bounds.IntersectsWith(lblWest.Bounds))
                {
                    this.Hide();
                    Rooms.Room_10 frmRoom10 = new Rooms.Room_10();
                    frmRoom10.Show();
                }
                else if (playerImage.Bounds.IntersectsWith(lblNorth.Bounds))
                {
                    MessageBox.Show("This path is blocked! Find a different path");
                    if (playerImage.Left > (lblEast.Height - 60))
                    {
                        playerImage.Top += 40;
                    }
                }
                else if (playerImage.Bounds.IntersectsWith(lblSouth.Bounds))
                {
                    MessageBox.Show("This path is blocked! Find a different path");
                    if (playerImage.Left > (lblEast.Height - 60))
                    {
                        playerImage.Top -= 40;
                    }
                }
            }


            switch (e.KeyCode)
            {
                case Keys.D:
                    if ((playerImage.Left + 10) < (this.Width - 60))
                        playerImage.Left += 20;
                    break;

                case Keys.A:
                    if ((playerImage.Left - 10) > 0)
                        playerImage.Left -= 20;
                    break;

                case Keys.W:
                    if ((playerImage.Top - 10) > 0)
                        playerImage.Top -= 20;
                    break;

                case Keys.S:
                    if ((playerImage.Top + 10) < (this.Height - (playerImage.Height + 30)))
                        playerImage.Top += 20;
                    break;

                case Keys.Escape:
                    frmPauseScreen frmPauseScreen = new frmPauseScreen();
                    frmPauseScreen.ShowDialog();
                    break;

                case Keys.P:
                    if (MessageBox.Show("Drop Coin?", "drop a bronze coin?", MessageBoxButtons.YesNo) == DialogResult.Yes && picBronze.Visible == false)
                    {
                        if (GlobalBoss.score <= 0)
                        {
                            MessageBox.Show("You have no wealth to drop.");
                        }
                        else
                        {
                            GlobalBoss.score = GlobalBoss.score - 1;
                            picBronze.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("You have already dropped a coin");
                    }
                    break;
            }
            Collision();
        }
        private void Collision()
        //prevents image from passing through walls/enemy 
        {           
                if (playerImage.Bounds.IntersectsWith(picDarkLinkBoss.Bounds))
                {
                    
                    if (GlobalBoss.darkLinkDefeated == false)
                    {
                        playerImage.Top = playerImage.Top + 40;
                        playerImage.Left = playerImage.Left + 40;
                        Boss_interactions.frmBossDarkLink darkLink = new Boss_interactions.frmBossDarkLink();
                        darkLink.ShowDialog();
                    }
                }
            if (playerImage.Bounds.IntersectsWith(picBronze.Bounds) && picBronze.Visible == true)
            {
                GlobalBoss.score = GlobalBoss.score + 1;
                picBronze.Visible = false;
            }
            lblScore.Text = "Score: " + GlobalBoss.score.ToString();
        }
    }
}
