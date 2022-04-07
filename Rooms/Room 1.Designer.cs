
namespace Maze
{
    partial class Room_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room_1));
            this.playerImage = new System.Windows.Forms.PictureBox();
            this.picKirbyBoss = new System.Windows.Forms.PictureBox();
            this.lblWest = new System.Windows.Forms.Label();
            this.lblEast = new System.Windows.Forms.Label();
            this.lblSouth = new System.Windows.Forms.Label();
            this.lblNorth = new System.Windows.Forms.Label();
            this.picBronze = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKirbyBoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBronze)).BeginInit();
            this.SuspendLayout();
            // 
            // playerImage
            // 
            this.playerImage.Image = ((System.Drawing.Image)(resources.GetObject("playerImage.Image")));
            this.playerImage.Location = new System.Drawing.Point(339, 459);
            this.playerImage.Name = "playerImage";
            this.playerImage.Size = new System.Drawing.Size(59, 64);
            this.playerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerImage.TabIndex = 0;
            this.playerImage.TabStop = false;
            // 
            // picKirbyBoss
            // 
            this.picKirbyBoss.Image = ((System.Drawing.Image)(resources.GetObject("picKirbyBoss.Image")));
            this.picKirbyBoss.Location = new System.Drawing.Point(241, 33);
            this.picKirbyBoss.Name = "picKirbyBoss";
            this.picKirbyBoss.Size = new System.Drawing.Size(242, 156);
            this.picKirbyBoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKirbyBoss.TabIndex = 1;
            this.picKirbyBoss.TabStop = false;
            // 
            // lblWest
            // 
            this.lblWest.AutoSize = true;
            this.lblWest.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWest.Location = new System.Drawing.Point(4, 287);
            this.lblWest.Name = "lblWest";
            this.lblWest.Size = new System.Drawing.Size(63, 29);
            this.lblWest.TabIndex = 2;
            this.lblWest.Text = "west";
            this.lblWest.Visible = false;
            // 
            // lblEast
            // 
            this.lblEast.AutoSize = true;
            this.lblEast.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEast.Location = new System.Drawing.Point(695, 299);
            this.lblEast.Name = "lblEast";
            this.lblEast.Size = new System.Drawing.Size(60, 29);
            this.lblEast.TabIndex = 3;
            this.lblEast.Text = "East";
            this.lblEast.Visible = false;
            // 
            // lblSouth
            // 
            this.lblSouth.AutoSize = true;
            this.lblSouth.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSouth.Location = new System.Drawing.Point(334, 570);
            this.lblSouth.Name = "lblSouth";
            this.lblSouth.Size = new System.Drawing.Size(75, 29);
            this.lblSouth.TabIndex = 4;
            this.lblSouth.Text = "South";
            this.lblSouth.Visible = false;
            // 
            // lblNorth
            // 
            this.lblNorth.AutoSize = true;
            this.lblNorth.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNorth.Location = new System.Drawing.Point(334, 9);
            this.lblNorth.Name = "lblNorth";
            this.lblNorth.Size = new System.Drawing.Size(72, 29);
            this.lblNorth.TabIndex = 5;
            this.lblNorth.Text = "North";
            this.lblNorth.Visible = false;
            // 
            // picBronze
            // 
            this.picBronze.Image = ((System.Drawing.Image)(resources.GetObject("picBronze.Image")));
            this.picBronze.Location = new System.Drawing.Point(570, 13);
            this.picBronze.Name = "picBronze";
            this.picBronze.Size = new System.Drawing.Size(57, 54);
            this.picBronze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBronze.TabIndex = 6;
            this.picBronze.TabStop = false;
            this.picBronze.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(13, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Score";
            // 
            // Room_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(758, 608);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picBronze);
            this.Controls.Add(this.lblNorth);
            this.Controls.Add(this.lblSouth);
            this.Controls.Add(this.lblEast);
            this.Controls.Add(this.lblWest);
            this.Controls.Add(this.picKirbyBoss);
            this.Controls.Add(this.playerImage);
            this.Name = "Room_1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKirbyBoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBronze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playerImage;
        private System.Windows.Forms.PictureBox picKirbyBoss;
        private System.Windows.Forms.Label lblWest;
        private System.Windows.Forms.Label lblEast;
        private System.Windows.Forms.Label lblSouth;
        private System.Windows.Forms.Label lblNorth;
        private System.Windows.Forms.PictureBox picBronze;
        private System.Windows.Forms.Label lblScore;
    }
}

