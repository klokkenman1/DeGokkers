namespace DeGokkers.Components
{
    partial class BetEntry
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lstAmount = new System.Windows.Forms.ComboBox();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lstAnimal = new System.Windows.Forms.ComboBox();
            this.btnBet = new System.Windows.Forms.Button();
            this.lblCash = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "<Name Here>";
            // 
            // lstAmount
            // 
            this.lstAmount.FormattingEnabled = true;
            this.lstAmount.Location = new System.Drawing.Point(128, 4);
            this.lstAmount.Name = "lstAmount";
            this.lstAmount.Size = new System.Drawing.Size(50, 21);
            this.lstAmount.TabIndex = 1;
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(184, 6);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(88, 13);
            this.lblDetail.TabIndex = 2;
            this.lblDetail.Text = "euro op de hond:";
            // 
            // lstAnimal
            // 
            this.lstAnimal.FormattingEnabled = true;
            this.lstAnimal.Location = new System.Drawing.Point(278, 4);
            this.lstAnimal.Name = "lstAnimal";
            this.lstAnimal.Size = new System.Drawing.Size(172, 21);
            this.lstAnimal.TabIndex = 3;
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(576, 1);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(75, 23);
            this.btnBet.TabIndex = 4;
            this.btnBet.Text = "Wed!";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Location = new System.Drawing.Point(468, 7);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(69, 13);
            this.lblCash.TabIndex = 5;
            this.lblCash.Text = "<Cash Here>";
            // 
            // BetEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.lstAnimal);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.lstAmount);
            this.Controls.Add(this.lblName);
            this.Name = "BetEntry";
            this.Size = new System.Drawing.Size(654, 26);
            this.Load += new System.EventHandler(this.BetEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox lstAmount;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.ComboBox lstAnimal;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label lblCash;
    }
}
