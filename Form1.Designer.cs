
namespace Maze
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playerImage = new System.Windows.Forms.PictureBox();
            this.picWall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall)).BeginInit();
            this.SuspendLayout();
            // 
            // playerImage
            // 
            this.playerImage.Image = ((System.Drawing.Image)(resources.GetObject("playerImage.Image")));
            this.playerImage.Location = new System.Drawing.Point(352, 534);
            this.playerImage.Name = "playerImage";
            this.playerImage.Size = new System.Drawing.Size(72, 62);
            this.playerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerImage.TabIndex = 0;
            this.playerImage.TabStop = false;
            // 
            // picWall
            // 
            this.picWall.Image = ((System.Drawing.Image)(resources.GetObject("picWall.Image")));
            this.picWall.Location = new System.Drawing.Point(339, 0);
            this.picWall.Name = "picWall";
            this.picWall.Size = new System.Drawing.Size(85, 156);
            this.picWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWall.TabIndex = 1;
            this.picWall.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 608);
            this.Controls.Add(this.picWall);
            this.Controls.Add(this.playerImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playerImage;
        private System.Windows.Forms.PictureBox picWall;
    }
}

