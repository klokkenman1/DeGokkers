namespace DeGokkers
{
    partial class UserWindow
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
            this.lblPlayersEntry = new System.Windows.Forms.Label();
            this.pnlPlayers = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.comboStartCash = new System.Windows.Forms.ComboBox();
            this.lblStartCash = new System.Windows.Forms.Label();
            this.pnlDogs = new System.Windows.Forms.Panel();
            this.grpPlayers = new System.Windows.Forms.GroupBox();
            this.grpAnimals = new System.Windows.Forms.GroupBox();
            this.grpPlayers.SuspendLayout();
            this.grpAnimals.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayersEntry
            // 
            this.lblPlayersEntry.AutoSize = true;
            this.lblPlayersEntry.Location = new System.Drawing.Point(12, 9);
            this.lblPlayersEntry.Name = "lblPlayersEntry";
            this.lblPlayersEntry.Size = new System.Drawing.Size(197, 13);
            this.lblPlayersEntry.TabIndex = 0;
            this.lblPlayersEntry.Text = "Stel de spelers in waarmee u wilt spelen.";
            // 
            // pnlPlayers
            // 
            this.pnlPlayers.AutoScroll = true;
            this.pnlPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlayers.Location = new System.Drawing.Point(3, 16);
            this.pnlPlayers.Name = "pnlPlayers";
            this.pnlPlayers.Size = new System.Drawing.Size(371, 169);
            this.pnlPlayers.TabIndex = 1;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(15, 468);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(375, 25);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Speel";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // comboStartCash
            // 
            this.comboStartCash.FormattingEnabled = true;
            this.comboStartCash.Location = new System.Drawing.Point(75, 444);
            this.comboStartCash.Name = "comboStartCash";
            this.comboStartCash.Size = new System.Drawing.Size(315, 21);
            this.comboStartCash.TabIndex = 3;
            // 
            // lblStartCash
            // 
            this.lblStartCash.AutoSize = true;
            this.lblStartCash.Location = new System.Drawing.Point(13, 447);
            this.lblStartCash.Name = "lblStartCash";
            this.lblStartCash.Size = new System.Drawing.Size(57, 13);
            this.lblStartCash.TabIndex = 0;
            this.lblStartCash.Text = "Start Geld:";
            // 
            // pnlDogs
            // 
            this.pnlDogs.AutoScroll = true;
            this.pnlDogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDogs.Location = new System.Drawing.Point(3, 16);
            this.pnlDogs.Name = "pnlDogs";
            this.pnlDogs.Size = new System.Drawing.Size(371, 201);
            this.pnlDogs.TabIndex = 5;
            // 
            // grpPlayers
            // 
            this.grpPlayers.Controls.Add(this.pnlPlayers);
            this.grpPlayers.Location = new System.Drawing.Point(13, 26);
            this.grpPlayers.Name = "grpPlayers";
            this.grpPlayers.Size = new System.Drawing.Size(377, 188);
            this.grpPlayers.TabIndex = 6;
            this.grpPlayers.TabStop = false;
            this.grpPlayers.Text = "Players";
            // 
            // grpAnimals
            // 
            this.grpAnimals.Controls.Add(this.pnlDogs);
            this.grpAnimals.Location = new System.Drawing.Point(13, 218);
            this.grpAnimals.Name = "grpAnimals";
            this.grpAnimals.Size = new System.Drawing.Size(377, 220);
            this.grpAnimals.TabIndex = 7;
            this.grpAnimals.TabStop = false;
            this.grpAnimals.Text = "Animals:";
            // 
            // UserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 505);
            this.Controls.Add(this.grpAnimals);
            this.Controls.Add(this.grpPlayers);
            this.Controls.Add(this.lblStartCash);
            this.Controls.Add(this.comboStartCash);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblPlayersEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserWindow";
            this.Text = "Select users to play game";
            this.Load += new System.EventHandler(this.UserWindow_Load);
            this.grpPlayers.ResumeLayout(false);
            this.grpAnimals.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayersEntry;
        private System.Windows.Forms.Panel pnlPlayers;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ComboBox comboStartCash;
        private System.Windows.Forms.Label lblStartCash;
        private System.Windows.Forms.Panel pnlDogs;
        private System.Windows.Forms.GroupBox grpPlayers;
        private System.Windows.Forms.GroupBox grpAnimals;
    }
}

