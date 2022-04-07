
namespace Maze.Boss_interactions
{
    partial class frmBossKirby
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBossKirby));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOptionOne = new System.Windows.Forms.Button();
            this.btnOptionTwo = new System.Windows.Forms.Button();
            this.btnOptionThree = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnOptionFive = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(230, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(46, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(679, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Boss Kirby has appeared! What will you do?";
            // 
            // btnOptionOne
            // 
            this.btnOptionOne.Location = new System.Drawing.Point(115, 256);
            this.btnOptionOne.Name = "btnOptionOne";
            this.btnOptionOne.Size = new System.Drawing.Size(127, 42);
            this.btnOptionOne.TabIndex = 2;
            this.btnOptionOne.Text = "Strawberry short cake";
            this.btnOptionOne.UseVisualStyleBackColor = true;
            this.btnOptionOne.Click += new System.EventHandler(this.btnOptionOne_Click);
            // 
            // btnOptionTwo
            // 
            this.btnOptionTwo.Location = new System.Drawing.Point(446, 256);
            this.btnOptionTwo.Name = "btnOptionTwo";
            this.btnOptionTwo.Size = new System.Drawing.Size(127, 42);
            this.btnOptionTwo.TabIndex = 3;
            this.btnOptionTwo.Text = "Master sword beam attack";
            this.btnOptionTwo.UseVisualStyleBackColor = true;
            this.btnOptionTwo.Click += new System.EventHandler(this.btnOptionTwo_Click);
            // 
            // btnOptionThree
            // 
            this.btnOptionThree.Location = new System.Drawing.Point(115, 334);
            this.btnOptionThree.Name = "btnOptionThree";
            this.btnOptionThree.Size = new System.Drawing.Size(127, 42);
            this.btnOptionThree.TabIndex = 4;
            this.btnOptionThree.Text = "Mirror Force";
            this.btnOptionThree.UseVisualStyleBackColor = true;
            this.btnOptionThree.Click += new System.EventHandler(this.btnOptionThree_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(446, 334);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(127, 42);
            this.btnFour.TabIndex = 5;
            this.btnFour.Text = "Moonblast";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnOptionFive
            // 
            this.btnOptionFive.Location = new System.Drawing.Point(282, 293);
            this.btnOptionFive.Name = "btnOptionFive";
            this.btnOptionFive.Size = new System.Drawing.Size(127, 42);
            this.btnOptionFive.TabIndex = 6;
            this.btnOptionFive.Text = "Eye of Nidhogg";
            this.btnOptionFive.UseVisualStyleBackColor = true;
            this.btnOptionFive.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmBossKirby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 419);
            this.Controls.Add(this.btnOptionFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnOptionThree);
            this.Controls.Add(this.btnOptionTwo);
            this.Controls.Add(this.btnOptionOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmBossKirby";
            this.Text = "Boss_Kirby";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOptionOne;
        private System.Windows.Forms.Button btnOptionTwo;
        private System.Windows.Forms.Button btnOptionThree;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnOptionFive;
    }
}