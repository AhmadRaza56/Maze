
namespace Maze.Rooms
{
    partial class Room_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room_2));
            this.lblSouth = new System.Windows.Forms.Label();
            this.lblEast = new System.Windows.Forms.Label();
            this.lblNorth = new System.Windows.Forms.Label();
            this.lblWest = new System.Windows.Forms.Label();
            this.picHydreigonBoss = new System.Windows.Forms.PictureBox();
            this.playerImage = new System.Windows.Forms.PictureBox();
            this.picBronze = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHydreigonBoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBronze)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSouth
            // 
            this.lblSouth.AutoSize = true;
            this.lblSouth.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSouth.Location = new System.Drawing.Point(315, 451);
            this.lblSouth.Name = "lblSouth";
            this.lblSouth.Size = new System.Drawing.Size(75, 29);
            this.lblSouth.TabIndex = 302;
            this.lblSouth.Text = "South";
            this.lblSouth.Visible = false;
            // 
            // lblEast
            // 
            this.lblEast.AutoSize = true;
            this.lblEast.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEast.Location = new System.Drawing.Point(632, 241);
            this.lblEast.Name = "lblEast";
            this.lblEast.Size = new System.Drawing.Size(60, 29);
            this.lblEast.TabIndex = 301;
            this.lblEast.Text = "East";
            this.lblEast.Visible = false;
            // 
            // lblNorth
            // 
            this.lblNorth.AutoSize = true;
            this.lblNorth.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNorth.Location = new System.Drawing.Point(315, 9);
            this.lblNorth.Name = "lblNorth";
            this.lblNorth.Size = new System.Drawing.Size(72, 29);
            this.lblNorth.TabIndex = 300;
            this.lblNorth.Text = "North";
            this.lblNorth.Visible = false;
            // 
            // lblWest
            // 
            this.lblWest.AutoSize = true;
            this.lblWest.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWest.Location = new System.Drawing.Point(12, 241);
            this.lblWest.Name = "lblWest";
            this.lblWest.Size = new System.Drawing.Size(67, 29);
            this.lblWest.TabIndex = 299;
            this.lblWest.Text = "West";
            this.lblWest.Visible = false;
            // 
            // picHydreigonBoss
            // 
            this.picHydreigonBoss.BackColor = System.Drawing.Color.White;
            this.picHydreigonBoss.Image = ((System.Drawing.Image)(resources.GetObject("picHydreigonBoss.Image")));
            this.picHydreigonBoss.Location = new System.Drawing.Point(246, 41);
            this.picHydreigonBoss.Name = "picHydreigonBoss";
            this.picHydreigonBoss.Size = new System.Drawing.Size(184, 199);
            this.picHydreigonBoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHydreigonBoss.TabIndex = 298;
            this.picHydreigonBoss.TabStop = false;
            // 
            // playerImage
            // 
            this.playerImage.BackColor = System.Drawing.SystemColors.Control;
            this.playerImage.Image = ((System.Drawing.Image)(resources.GetObject("playerImage.Image")));
            this.playerImage.Location = new System.Drawing.Point(309, 381);
            this.playerImage.Name = "playerImage";
            this.playerImage.Size = new System.Drawing.Size(75, 70);
            this.playerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerImage.TabIndex = 297;
            this.playerImage.TabStop = false;
            // 
            // picBronze
            // 
            this.picBronze.Image = ((System.Drawing.Image)(resources.GetObject("picBronze.Image")));
            this.picBronze.Location = new System.Drawing.Point(571, 59);
            this.picBronze.Name = "picBronze";
            this.picBronze.Size = new System.Drawing.Size(62, 50);
            this.picBronze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBronze.TabIndex = 420;
            this.picBronze.TabStop = false;
            this.picBronze.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(17, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 421;
            this.lblScore.Text = "label1";
            // 
            // Room_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 489);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picBronze);
            this.Controls.Add(this.lblSouth);
            this.Controls.Add(this.lblEast);
            this.Controls.Add(this.lblNorth);
            this.Controls.Add(this.lblWest);
            this.Controls.Add(this.picHydreigonBoss);
            this.Controls.Add(this.playerImage);
            this.Name = "Room_2";
            this.Text = "Room_2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Room_2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picHydreigonBoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBronze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSouth;
        private System.Windows.Forms.Label lblEast;
        private System.Windows.Forms.Label lblNorth;
        private System.Windows.Forms.Label lblWest;
        private System.Windows.Forms.PictureBox picHydreigonBoss;
        private System.Windows.Forms.PictureBox playerImage;
        private System.Windows.Forms.PictureBox picBronze;
        private System.Windows.Forms.Label lblScore;
    }
}