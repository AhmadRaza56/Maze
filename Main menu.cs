using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class frmStartUp : Form
    {
        public frmStartUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmControls controls = new frmControls();
            controls.ShowDialog();
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCredits credits = new frmCredits();
            credits.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           // string path = @"C:\Users\"+ Environment.UserName +@"\OneDrive\Desktop\maze game\Configuration.txt";
           // string text = System.IO.File.ReadAllText(path);
           // string configuration = (path);

           // if (File.Exists(configuration))
            
               // MessageBox.Show(text);
                GlobalBoss.score = 0;
                GlobalBoss.lahabreaDefeated = false;
                GlobalBoss.kirbyDefeated = false;
                GlobalBoss.hydreigonDefeated = false;
                GlobalBoss.darkLinkDefeated = false;
                GlobalBoss.blueEyesDefeated = false;
                Random rnd = new Random();
                int room = rnd.Next(1, 13);
            switch (room)
            {
                case 1:
                    this.Hide();
                    Room_1 room_1 = new Room_1();
                    room_1.ShowDialog();
                    break;

                case 2:
                    this.Hide();
                    Rooms.Room_2 room_2 = new Rooms.Room_2();
                    room_2.ShowDialog();
                    break;

                case 3:
                    this.Hide();
                    Rooms.Room_3 room_3 = new Rooms.Room_3();
                    room_3.ShowDialog();
                    break;

                case 4:
                    this.Hide();
                    Rooms.room_4 room_4 = new Rooms.room_4();
                    room_4.ShowDialog();
                    break;

                case 5:
                    this.Hide();
                    Rooms.Room_5 room_5 = new Rooms.Room_5();
                    room_5.ShowDialog();
                    break;

                case 6:
                    this.Hide();
                    Rooms.Room_6 room_6 = new Rooms.Room_6();
                    room_6.ShowDialog();
                    break;

                case 7:
                    this.Hide();
                    Rooms.Room_7 room_7 = new Rooms.Room_7();
                    room_7.ShowDialog();
                    break;

                case 8:
                    this.Hide();
                    Rooms.Room_8 room_8 = new Rooms.Room_8();
                    room_8.ShowDialog();
                    break;

                case 9:
                    this.Hide();
                    Rooms.Room_9 room_9 = new Rooms.Room_9();
                    room_9.ShowDialog();
                    break;

                case 10:
                    this.Hide();
                    Rooms.Room_10 room_10 = new Rooms.Room_10();
                    room_10.ShowDialog();
                    break;

                case 11:
                    this.Hide();
                    Rooms.Room_11 room_11 = new Rooms.Room_11();
                    room_11.ShowDialog();
                    break;

                case 12:
                    this.Hide();
                    Rooms.Room_12 room_12 = new Rooms.Room_12();
                    room_12.ShowDialog();
                    break;

            }
           // else
          //  {
          //      MessageBox.Show("Configuration File is missing, please check to make sure is valid.");
           // }
        }

        private void lblQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
