namespace Space_Invaders_Summative
{
    partial class EndScreen
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
            this.winOrLoseLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // winOrLoseLabel
            // 
            this.winOrLoseLabel.AutoSize = true;
            this.winOrLoseLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.winOrLoseLabel.Font = new System.Drawing.Font("Bauhaus 93", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winOrLoseLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.winOrLoseLabel.Location = new System.Drawing.Point(25, 127);
            this.winOrLoseLabel.Name = "winOrLoseLabel";
            this.winOrLoseLabel.Size = new System.Drawing.Size(455, 73);
            this.winOrLoseLabel.TabIndex = 3;
            this.winOrLoseLabel.Text = "Space Invaders";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scoreLabel.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.scoreLabel.Location = new System.Drawing.Point(159, 242);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(193, 24);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "Press Space To Play";
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.winOrLoseLabel);
            this.Name = "EndScreen";
            this.Size = new System.Drawing.Size(507, 392);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EndScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EndScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label winOrLoseLabel;
        private System.Windows.Forms.Label scoreLabel;
    }
}
