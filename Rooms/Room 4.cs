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
    public partial class room_4 : Form
    {
        public room_4()
        {
            InitializeComponent();
            if (GlobalBoss.reset == true)
            {
                picSilver.Visible = true;
                picGold1.Visible = true;
                picGold2.Visible = true;
                picBronze.Visible = false;
                GlobalBoss.reset = false;
            }
        }

        private void room_4_KeyDown(object sender, KeyEventArgs e)
        {
            if (picSilver.Visible == false && picGold1.Visible == false && picGold2.Visible == false)
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
                Rooms.Room_8 room8 = new Rooms.Room_8();
                room8.Show();
            }
            if (lblNorth.Bounds.IntersectsWith(playerImage.Bounds) && lblNorth.Visible == true)
            {
                this.Hide();
                Rooms.Room_3 room3 = new Rooms.Room_3();
                room3.Show();
            }
            if (lblSouth.Bounds.IntersectsWith(playerImage.Bounds) && lblSouth.Visible == true)
            {
                this.Hide();
                Rooms.Room_2 room2 = new Rooms.Room_2();
                room2.Show();
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
                        if ((playerImage.Left + 10) < (this.Width - 60))
                            playerImage.Left += 10;
                        break;

                    case Keys.A:
                        if ((playerImage.Left - 10) > 0)
                            playerImage.Left -= 10;
                        break;

                    case Keys.W:
                        if ((playerImage.Top - 10) > 0)
                            playerImage.Top -= 10;
                        break;

                    case Keys.S:
                        if ((playerImage.Top + 10) < (this.Height - (playerImage.Height + 20)))
                            playerImage.Top += 10;
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
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "walls" && x.Visible == true)
                {
                    if (playerImage.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerImage.Location = new Point(415, 528);
                    }
                }
            }
            foreach (Control y in this.Controls)
            {
                if (y is PictureBox && (string)y.Tag == "wealth")
                {
                    if (playerImage.Bounds.IntersectsWith(y.Bounds) && y.Visible == true)
                    {
                        if (playerImage.Bounds.IntersectsWith(picSilver.Bounds))
                        {
                            GlobalBoss.score = GlobalBoss.score + 2;
                        }
                        else if (playerImage.Bounds.IntersectsWith(picGold1.Bounds))
                        {
                            GlobalBoss.score = GlobalBoss.score + 4;
                        }
                        else if (playerImage.Bounds.IntersectsWith(picGold2.Bounds))
                        {
                            GlobalBoss.score = GlobalBoss.score + 4;
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
