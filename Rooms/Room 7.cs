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
    public partial class Room_7 : Form
    {
        public Room_7()
        {
            InitializeComponent();
            if (GlobalBoss.reset == true)
            {
                picSilver1.Visible = true;
                picSilver2.Visible = true;
                picSilver3.Visible = true;
                picBronze.Visible = false;
                GlobalBoss.reset = false;
            }

        }

        private void Room_7_KeyDown(object sender, KeyEventArgs e)
        {
            if (picSilver1.Visible == false && picSilver2.Visible == false && picSilver3.Visible == false)
            {
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && (string)x.Tag == "walls")
                    {
                        x.Visible = false;
                        lblEast.Visible = true;
                        lblNorth.Visible = true;
                        lblSouth.Visible = true;
                        lblWest.Visible = true;
                    }
                }
            }

            if (lblEast.Bounds.IntersectsWith(playerImage.Bounds) && lblEast.Visible == true)
            {
                this.Hide();
                Room_1 room1 = new Room_1();
                room1.Show();
            }
            if (lblNorth.Bounds.IntersectsWith(playerImage.Bounds) && lblNorth.Visible == true)
            {
                MessageBox.Show("This path is blocked! Find a different path");
                if (playerImage.Top > (lblNorth.Height - 60))
                {
                    playerImage.Top += 40;
                }
            }
            if (lblSouth.Bounds.IntersectsWith(playerImage.Bounds) && lblSouth.Visible == true)
            {
                MessageBox.Show("This path is blocked! Find a different path");
                if (playerImage.Top > (lblSouth.Height - 60))
                {
                    playerImage.Top -= 40;
                }
            }
            if (lblWest.Bounds.IntersectsWith(playerImage.Bounds) && lblWest.Visible == true)
            {
                MessageBox.Show("This path is blocked! Find a different path");
                if (playerImage.Left < (lblWest.Width))
                {
                    playerImage.Left += 40;
                }
            }

            switch (e.KeyCode)
            {
                case Keys.D:
                    if ((playerImage.Left + 20) < (this.Width - 60))
                        playerImage.Left += 20;
                    break;

                case Keys.A:
                    if ((playerImage.Left - 20) > 0)
                        playerImage.Left -= 20;
                    break;

                case Keys.W:
                    if ((playerImage.Top - 20) > 0)
                        playerImage.Top -= 20;
                    break;

                case Keys.S:
                    if ((playerImage.Top + 20) < (this.Height - (playerImage.Height + 30)))
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
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "walls" && x.Visible == true)
                {
                    if (playerImage.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerImage.Location = new Point(402, 495);
                    }
                }
            }
            foreach (Control y in this.Controls)
            {
                if (y is PictureBox && (string)y.Tag == "wealth")
                {
                    if (playerImage.Bounds.IntersectsWith(y.Bounds) && y.Visible == true)
                    {
                        if (playerImage.Bounds.IntersectsWith(picSilver1.Bounds))
                        {
                            GlobalBoss.score = GlobalBoss.score + 2;
                        }
                        else if (playerImage.Bounds.IntersectsWith(picSilver2.Bounds))
                        {
                            GlobalBoss.score = GlobalBoss.score + 2;
                        }
                        else if (playerImage.Bounds.IntersectsWith(picSilver3.Bounds))
                        {
                            GlobalBoss.score = GlobalBoss.score + 2;
                        }
                        y.Visible = false;
                    }
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
