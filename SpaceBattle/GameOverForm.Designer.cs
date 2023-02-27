namespace SpaceBattle
{
    partial class GameOverForm
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
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.returnBtn_gameOverForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.Black;
            this.gameOverLabel.Location = new System.Drawing.Point(292, 146);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(654, 282);
            this.gameOverLabel.TabIndex = 0;
            this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // returnBtn_gameOverForm
            // 
            this.returnBtn_gameOverForm.BackColor = System.Drawing.Color.Transparent;
            this.returnBtn_gameOverForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBtn_gameOverForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn_gameOverForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.returnBtn_gameOverForm.ForeColor = System.Drawing.Color.White;
            this.returnBtn_gameOverForm.Location = new System.Drawing.Point(2, 554);
            this.returnBtn_gameOverForm.Name = "returnBtn_gameOverForm";
            this.returnBtn_gameOverForm.Size = new System.Drawing.Size(297, 45);
            this.returnBtn_gameOverForm.TabIndex = 5;
            this.returnBtn_gameOverForm.Text = "Return";
            this.returnBtn_gameOverForm.UseVisualStyleBackColor = false;
            this.returnBtn_gameOverForm.Click += new System.EventHandler(this.returnBtn_gameOverForm_Click);
            this.returnBtn_gameOverForm.MouseEnter += new System.EventHandler(this.returnBtn_gameOverForm_MouseEnter);
            this.returnBtn_gameOverForm.MouseLeave += new System.EventHandler(this.returnBtn_gameOverForm_MouseLeave);
            // 
            // GameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceBattle.Properties.Resources.star_wars_backgrounds_28_gameover;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 611);
            this.Controls.Add(this.returnBtn_gameOverForm);
            this.Controls.Add(this.gameOverLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameOverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GameOverForm";
            this.Load += new System.EventHandler(this.GameOverForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Button returnBtn_gameOverForm;
    }
}