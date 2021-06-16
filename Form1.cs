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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
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
            }
            Collision();
        }           
        
        private void Collision()
            //prevents image from passing through walls/enemy 
        {
            if (playerImage.Bounds.IntersectsWith(picWall.Bounds))
            {
                playerImage.Top = playerImage.Top + 40;
                playerImage.Left = playerImage.Left + 40;
            }
        }
    }
}
