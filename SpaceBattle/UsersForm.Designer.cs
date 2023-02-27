namespace SpaceBattle
{
    partial class UsersForm
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
            this.components = new System.ComponentModel.Container();
            this.usersLabel_UsersForm = new System.Windows.Forms.Label();
            this.UserslistBox = new System.Windows.Forms.ListBox();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.returnButton_UsersForm = new System.Windows.Forms.Button();
            this.playButton_UsersForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usersLabel_UsersForm
            // 
            this.usersLabel_UsersForm.BackColor = System.Drawing.Color.Transparent;
            this.usersLabel_UsersForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersLabel_UsersForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.usersLabel_UsersForm.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.usersLabel_UsersForm.Location = new System.Drawing.Point(0, 0);
            this.usersLabel_UsersForm.Name = "usersLabel_UsersForm";
            this.usersLabel_UsersForm.Size = new System.Drawing.Size(1264, 62);
            this.usersLabel_UsersForm.TabIndex = 0;
            this.usersLabel_UsersForm.Text = "Users";
            this.usersLabel_UsersForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserslistBox
            // 
            this.UserslistBox.BackColor = System.Drawing.Color.Gray;
            this.UserslistBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserslistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.UserslistBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.UserslistBox.FormattingEnabled = true;
            this.UserslistBox.ItemHeight = 31;
            this.UserslistBox.Location = new System.Drawing.Point(502, 88);
            this.UserslistBox.Name = "UserslistBox";
            this.UserslistBox.Size = new System.Drawing.Size(283, 341);
            this.UserslistBox.Sorted = true;
            this.UserslistBox.TabIndex = 1;
            this.UserslistBox.SelectedIndexChanged += new System.EventHandler(this.UserslistBox_SelectedIndexChanged);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(SpaceBattle.Program);
            // 
            // returnButton_UsersForm
            // 
            this.returnButton_UsersForm.BackColor = System.Drawing.Color.Transparent;
            this.returnButton_UsersForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnButton_UsersForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton_UsersForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.returnButton_UsersForm.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.returnButton_UsersForm.Location = new System.Drawing.Point(12, 554);
            this.returnButton_UsersForm.Name = "returnButton_UsersForm";
            this.returnButton_UsersForm.Size = new System.Drawing.Size(297, 45);
            this.returnButton_UsersForm.TabIndex = 2;
            this.returnButton_UsersForm.Text = "Return";
            this.returnButton_UsersForm.UseVisualStyleBackColor = false;
            this.returnButton_UsersForm.Click += new System.EventHandler(this.returnButton_UsersForm_Click);
            this.returnButton_UsersForm.MouseEnter += new System.EventHandler(this.returnButton_UsersForm_MouseEnter);
            this.returnButton_UsersForm.MouseLeave += new System.EventHandler(this.returnButton_UsersForm_MouseLeave);
            // 
            // playButton_UsersForm
            // 
            this.playButton_UsersForm.BackColor = System.Drawing.Color.Transparent;
            this.playButton_UsersForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton_UsersForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton_UsersForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.playButton_UsersForm.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.playButton_UsersForm.Location = new System.Drawing.Point(955, 554);
            this.playButton_UsersForm.Name = "playButton_UsersForm";
            this.playButton_UsersForm.Size = new System.Drawing.Size(297, 45);
            this.playButton_UsersForm.TabIndex = 3;
            this.playButton_UsersForm.Text = "PLAY";
            this.playButton_UsersForm.UseVisualStyleBackColor = false;
            this.playButton_UsersForm.Click += new System.EventHandler(this.playButton_UsersForm_Click);
            this.playButton_UsersForm.MouseEnter += new System.EventHandler(this.playButton_UsersForm_MouseEnter);
            this.playButton_UsersForm.MouseLeave += new System.EventHandler(this.playButton_UsersForm_MouseLeave);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceBattle.Properties.Resources.star_wars_backgrounds_01_controls;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 611);
            this.Controls.Add(this.playButton_UsersForm);
            this.Controls.Add(this.returnButton_UsersForm);
            this.Controls.Add(this.usersLabel_UsersForm);
            this.Controls.Add(this.UserslistBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsersForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label usersLabel_UsersForm;
        private System.Windows.Forms.ListBox UserslistBox;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.Button returnButton_UsersForm;
        private System.Windows.Forms.Button playButton_UsersForm;
    }
}