
namespace Maze.Boss_interactions
{
    partial class frmBossHydreigon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBossHydreigon));
            this.button5 = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnOptionThree = new System.Windows.Forms.Button();
            this.btnOptionTwo = new System.Windows.Forms.Button();
            this.btnOptionOne = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(297, 316);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 42);
            this.button5.TabIndex = 13;
            this.button5.Text = "Eye of Nidhogg";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(461, 357);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(127, 42);
            this.btnFour.TabIndex = 12;
            this.btnFour.Text = "Moonblast";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnOptionThree
            // 
            this.btnOptionThree.Location = new System.Drawing.Point(130, 357);
            this.btnOptionThree.Name = "btnOptionThree";
            this.btnOptionThree.Size = new System.Drawing.Size(127, 42);
            this.btnOptionThree.TabIndex = 11;
            this.btnOptionThree.Text = "Mirror Force";
            this.btnOptionThree.UseVisualStyleBackColor = true;
            this.btnOptionThree.Click += new System.EventHandler(this.btnOptionThree_Click);
            // 
            // btnOptionTwo
            // 
            this.btnOptionTwo.Location = new System.Drawing.Point(461, 279);
            this.btnOptionTwo.Name = "btnOptionTwo";
            this.btnOptionTwo.Size = new System.Drawing.Size(127, 42);
            this.btnOptionTwo.TabIndex = 10;
            this.btnOptionTwo.Text = "Master sword beam attack";
            this.btnOptionTwo.UseVisualStyleBackColor = true;
            this.btnOptionTwo.Click += new System.EventHandler(this.btnOptionTwo_Click);
            // 
            // btnOptionOne
            // 
            this.btnOptionOne.Location = new System.Drawing.Point(130, 279);
            this.btnOptionOne.Name = "btnOptionOne";
            this.btnOptionOne.Size = new System.Drawing.Size(127, 42);
            this.btnOptionOne.TabIndex = 9;
            this.btnOptionOne.Text = "Strawberry short cake";
            this.btnOptionOne.UseVisualStyleBackColor = true;
            this.btnOptionOne.Click += new System.EventHandler(this.btnOptionOne_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(756, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Boss Hydreigon has appeared! What will you do?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(262, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmBossHydreigon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnOptionThree);
            this.Controls.Add(this.btnOptionTwo);
            this.Controls.Add(this.btnOptionOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmBossHydreigon";
            this.Text = "Boss_Hydreigon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnOptionThree;
        private System.Windows.Forms.Button btnOptionTwo;
        private System.Windows.Forms.Button btnOptionOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}