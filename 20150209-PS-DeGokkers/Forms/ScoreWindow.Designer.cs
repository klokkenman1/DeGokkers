namespace DeGokkers.Forms
{
    partial class ScoreWindow
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
            this.pnlAnimals = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblNames = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAnimals
            // 
            this.pnlAnimals.AutoScroll = true;
            this.pnlAnimals.Location = new System.Drawing.Point(12, 147);
            this.pnlAnimals.Name = "pnlAnimals";
            this.pnlAnimals.Size = new System.Drawing.Size(337, 245);
            this.pnlAnimals.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DeGokkers.Properties.Resources.checkered_flags;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(13, 131);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(34, 13);
            this.lblPlace.TabIndex = 2;
            this.lblPlace.Text = "Place";
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Location = new System.Drawing.Point(83, 131);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(40, 13);
            this.lblNames.TabIndex = 0;
            this.lblNames.Text = "Names";
            // 
            // ScoreWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 404);
            this.Controls.Add(this.lblNames);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlAnimals);
            this.Name = "ScoreWindow";
            this.Text = "ScoreWindow";
            this.Load += new System.EventHandler(this.ScoreWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAnimals;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblNames;
    }
}