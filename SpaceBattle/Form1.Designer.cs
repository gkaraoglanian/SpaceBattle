namespace SpaceBattle
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.usersButton = new System.Windows.Forms.Button();
            this.recordsButton = new System.Windows.Forms.Button();
            this.newUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Moccasin;
            this.label1.Name = "label1";
            // 
            // usersButton
            // 
            this.usersButton.BackColor = System.Drawing.Color.Black;
            this.usersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.usersButton, "usersButton");
            this.usersButton.ForeColor = System.Drawing.Color.Moccasin;
            this.usersButton.Name = "usersButton";
            this.usersButton.UseVisualStyleBackColor = false;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            this.usersButton.MouseEnter += new System.EventHandler(this.usersButton_MouseEnter);
            this.usersButton.MouseLeave += new System.EventHandler(this.userButton_MouseLeave);
            // 
            // recordsButton
            // 
            this.recordsButton.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.recordsButton, "recordsButton");
            this.recordsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recordsButton.ForeColor = System.Drawing.Color.Moccasin;
            this.recordsButton.Name = "recordsButton";
            this.recordsButton.UseVisualStyleBackColor = false;
            this.recordsButton.Click += new System.EventHandler(this.recordsButton_Click);
            this.recordsButton.MouseEnter += new System.EventHandler(this.recordsButton_MouseEnter);
            this.recordsButton.MouseLeave += new System.EventHandler(this.recordsButton_MouseLeave);
            // 
            // newUserButton
            // 
            this.newUserButton.BackColor = System.Drawing.Color.Black;
            this.newUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.newUserButton, "newUserButton");
            this.newUserButton.ForeColor = System.Drawing.Color.Moccasin;
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.UseVisualStyleBackColor = false;
            this.newUserButton.Click += new System.EventHandler(this.newUserButton_Click);
            this.newUserButton.MouseEnter += new System.EventHandler(this.newUserButton_MouseEnter);
            this.newUserButton.MouseLeave += new System.EventHandler(this.newUserButton_MouseLeave);
            // 
            // WelcomeForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceBattle.Properties.Resources.star_wars_backgrounds_20_1;
            this.Controls.Add(this.newUserButton);
            this.Controls.Add(this.recordsButton);
            this.Controls.Add(this.usersButton);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomeForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button recordsButton;
        private System.Windows.Forms.Button newUserButton;
    }
}

