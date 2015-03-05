namespace DeGokkers.Components
{
    partial class AnimalPackSelection
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
            this.rndSelect = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rndSelect
            // 
            this.rndSelect.AutoSize = true;
            this.rndSelect.BackColor = System.Drawing.Color.Transparent;
            this.rndSelect.Location = new System.Drawing.Point(68, 164);
            this.rndSelect.Name = "rndSelect";
            this.rndSelect.Size = new System.Drawing.Size(14, 13);
            this.rndSelect.TabIndex = 0;
            this.rndSelect.TabStop = true;
            this.rndSelect.UseVisualStyleBackColor = false;
            // 
            // AnimalPackSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeGokkers.Properties.Resources.card_animal;
            this.Controls.Add(this.rndSelect);
            this.Name = "AnimalPackSelection";
            this.Size = new System.Drawing.Size(150, 180);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rndSelect;




    }
}
