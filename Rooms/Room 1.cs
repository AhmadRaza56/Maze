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
  
    public partial class Room_1 : Form
    {        
        

        public Room_1()
        {            
            InitializeComponent();
            if (GlobalBoss.reset == true)
            {
                picBronze.Visible = false;
                GlobalBoss.reset = false;
            }
        }

       
    private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (GlobalBoss.kirbyDefeated == true)
            {
                picKirbyBoss.Visible = false;
                lblEast.Visible = true;
                lblNorth.Visible = true;
                lblSouth.Visible = true;
                lblWest.Visible = true;

                if (playerImage.Bounds.IntersectsWith(lblEast.Bounds))
                {
                    this.Hide();
                    Rooms.room_4 frmRoom4 = new Rooms.room_4();
                    frmRoom4.Show();
                }
                else if (playerImage.Bounds.IntersectsWith(lblWest.Bounds))
                {
                    this.Hide();
                    Rooms.Room_7 frmRoom7 = new Rooms.Room_7();
                    frmRoom7.Show();
                }
                else if (playerImage.Bounds.IntersectsWith(lblNorth.Bounds))
                {
                    this.Hide();
                    Rooms.Room_3 frmRoom3 = new Rooms.Room_3();
                    frmRoom3.Show();
                }
                else if (playerImage.Bounds.IntersectsWith(lblSouth.Bounds))
                {
                    this.Hide();
                    Rooms.Room_5 frmRoom5 = new Rooms.Room_5();
                    frmRoom5.Show();
                }
            }

            switch (e.KeyCode)
            {
                case Keys.D:
                    if ((playerImage.Left + 20)<(this.Width - playerImage.Width))
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
            if (playerImage.Bounds.IntersectsWith(picKirbyBoss.Bounds))
            {
                if (GlobalBoss.kirbyDefeated == false)
                {
                    playerImage.Top = playerImage.Top + 40;
                    playerImage.Left = playerImage.Left + 40;
                    Boss_interactions.frmBossKirby Kirby = new Boss_interactions.frmBossKirby();
                    Kirby.ShowDialog();
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

static class GlobalBoss
{
    
    public static bool kirbyDefeated = false;
    public static bool darkLinkDefeated = false;
    public static bool blueEyesDefeated = false;
    public static bool lahabreaDefeated = false;
    public static bool hydreigonDefeated = false;
    public static int score;
    public static bool reset = false;
}