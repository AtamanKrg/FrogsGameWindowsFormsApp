namespace FrogsGameWindowsFormsApp
{
    partial class RulesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulesForm));
            this.rulesFormPictureBox = new System.Windows.Forms.PictureBox();
            this.rulesTextLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rulesFormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // rulesFormPictureBox
            // 
            this.rulesFormPictureBox.Image = global::FrogsGameWindowsFormsApp.Properties.Resources.FrogsGamePicture1;
            this.rulesFormPictureBox.Location = new System.Drawing.Point(90, 30);
            this.rulesFormPictureBox.Name = "rulesFormPictureBox";
            this.rulesFormPictureBox.Size = new System.Drawing.Size(200, 170);
            this.rulesFormPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rulesFormPictureBox.TabIndex = 0;
            this.rulesFormPictureBox.TabStop = false;
            // 
            // rulesTextLabel
            // 
            this.rulesTextLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(50)))), ((int)(((byte)(7)))));
            this.rulesTextLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rulesTextLabel.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.rulesTextLabel.Location = new System.Drawing.Point(12, 230);
            this.rulesTextLabel.Name = "rulesTextLabel";
            this.rulesTextLabel.Size = new System.Drawing.Size(358, 214);
            this.rulesTextLabel.TabIndex = 1;
            this.rulesTextLabel.Text = resources.GetString("rulesTextLabel.Text");
            this.rulesTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(50)))), ((int)(((byte)(7)))));
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.rulesTextLabel);
            this.Controls.Add(this.rulesFormPictureBox);
            this.MinimizeBox = false;
            this.Name = "RulesForm";
            this.Text = "RulesForm";
            ((System.ComponentModel.ISupportInitialize)(this.rulesFormPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox rulesFormPictureBox;
        private System.Windows.Forms.Label rulesTextLabel;
    }
}