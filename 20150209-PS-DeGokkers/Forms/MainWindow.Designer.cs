namespace DeGokkers.Forms
{
    partial class MainWindow
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
            this.grpBetting = new System.Windows.Forms.GroupBox();
            this.pnlBets = new System.Windows.Forms.Panel();
            this.lblStartRace = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pctTrack = new System.Windows.Forms.PictureBox();
            this.grpBetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBetting
            // 
            this.grpBetting.Controls.Add(this.pnlBets);
            this.grpBetting.Location = new System.Drawing.Point(12, 322);
            this.grpBetting.Name = "grpBetting";
            this.grpBetting.Size = new System.Drawing.Size(720, 197);
            this.grpBetting.TabIndex = 0;
            this.grpBetting.TabStop = false;
            this.grpBetting.Text = "Betting";
            // 
            // pnlBets
            // 
            this.pnlBets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBets.Location = new System.Drawing.Point(3, 16);
            this.pnlBets.Name = "pnlBets";
            this.pnlBets.Size = new System.Drawing.Size(714, 178);
            this.pnlBets.TabIndex = 0;
            // 
            // lblStartRace
            // 
            this.lblStartRace.Location = new System.Drawing.Point(12, 268);
            this.lblStartRace.Name = "lblStartRace";
            this.lblStartRace.Size = new System.Drawing.Size(720, 48);
            this.lblStartRace.TabIndex = 2;
            this.lblStartRace.Text = "GO";
            this.lblStartRace.UseVisualStyleBackColor = true;
            this.lblStartRace.Click += new System.EventHandler(this.startRace_Click);
            // 
            // pctTrack
            // 
            this.pctTrack.Location = new System.Drawing.Point(12, 12);
            this.pctTrack.Name = "pctTrack";
            this.pctTrack.Size = new System.Drawing.Size(720, 250);
            this.pctTrack.TabIndex = 1;
            this.pctTrack.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 522);
            this.Controls.Add(this.lblStartRace);
            this.Controls.Add(this.pctTrack);
            this.Controls.Add(this.grpBetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainWindow";
            this.Text = "De Gokkers";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.grpBetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBetting;
        private System.Windows.Forms.Panel pnlBets;
        private System.Windows.Forms.PictureBox pctTrack;
        private System.Windows.Forms.Button lblStartRace;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}