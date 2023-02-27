namespace SpaceBattle
{
    partial class newUserForm
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
            this.newUsr_newUserForm = new System.Windows.Forms.Label();
            this.usrname_textBox_newUserForm = new System.Windows.Forms.TextBox();
            this.userbameLbl_newUserForm = new System.Windows.Forms.Label();
            this.returnBtn_newUserForm = new System.Windows.Forms.Button();
            this.playBtn_newUserForm = new System.Windows.Forms.Button();
            this.submitBtn_newUserForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newUsr_newUserForm
            // 
            this.newUsr_newUserForm.BackColor = System.Drawing.Color.Transparent;
            this.newUsr_newUserForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.newUsr_newUserForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newUsr_newUserForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.newUsr_newUserForm.ForeColor = System.Drawing.Color.Firebrick;
            this.newUsr_newUserForm.Location = new System.Drawing.Point(0, 0);
            this.newUsr_newUserForm.Name = "newUsr_newUserForm";
            this.newUsr_newUserForm.Size = new System.Drawing.Size(1264, 113);
            this.newUsr_newUserForm.TabIndex = 0;
            this.newUsr_newUserForm.Text = "New User Registration";
            this.newUsr_newUserForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usrname_textBox_newUserForm
            // 
            this.usrname_textBox_newUserForm.AcceptsTab = true;
            this.usrname_textBox_newUserForm.BackColor = System.Drawing.Color.Silver;
            this.usrname_textBox_newUserForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usrname_textBox_newUserForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.usrname_textBox_newUserForm.Location = new System.Drawing.Point(425, 220);
            this.usrname_textBox_newUserForm.Name = "usrname_textBox_newUserForm";
            this.usrname_textBox_newUserForm.Size = new System.Drawing.Size(369, 31);
            this.usrname_textBox_newUserForm.TabIndex = 1;
            this.usrname_textBox_newUserForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usrname_textBox_newUserForm.TextChanged += new System.EventHandler(this.usrname_textBox_newUserForm_TextChanged);
            // 
            // userbameLbl_newUserForm
            // 
            this.userbameLbl_newUserForm.BackColor = System.Drawing.Color.Transparent;
            this.userbameLbl_newUserForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userbameLbl_newUserForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.userbameLbl_newUserForm.ForeColor = System.Drawing.Color.Firebrick;
            this.userbameLbl_newUserForm.Location = new System.Drawing.Point(523, 168);
            this.userbameLbl_newUserForm.Name = "userbameLbl_newUserForm";
            this.userbameLbl_newUserForm.Size = new System.Drawing.Size(184, 49);
            this.userbameLbl_newUserForm.TabIndex = 2;
            this.userbameLbl_newUserForm.Text = "Username";
            this.userbameLbl_newUserForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // returnBtn_newUserForm
            // 
            this.returnBtn_newUserForm.BackColor = System.Drawing.Color.Transparent;
            this.returnBtn_newUserForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBtn_newUserForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn_newUserForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.returnBtn_newUserForm.ForeColor = System.Drawing.Color.Firebrick;
            this.returnBtn_newUserForm.Location = new System.Drawing.Point(10, 554);
            this.returnBtn_newUserForm.Name = "returnBtn_newUserForm";
            this.returnBtn_newUserForm.Size = new System.Drawing.Size(297, 45);
            this.returnBtn_newUserForm.TabIndex = 4;
            this.returnBtn_newUserForm.Text = "Return";
            this.returnBtn_newUserForm.UseVisualStyleBackColor = false;
            this.returnBtn_newUserForm.Click += new System.EventHandler(this.returnBtn_newUserForm_Click);
            this.returnBtn_newUserForm.MouseEnter += new System.EventHandler(this.returnBtn_newUserForm_MouseEnter);
            this.returnBtn_newUserForm.MouseLeave += new System.EventHandler(this.returnBtn_newUserForm_MouseLeave);
            // 
            // playBtn_newUserForm
            // 
            this.playBtn_newUserForm.BackColor = System.Drawing.Color.Transparent;
            this.playBtn_newUserForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playBtn_newUserForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playBtn_newUserForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.playBtn_newUserForm.ForeColor = System.Drawing.Color.Firebrick;
            this.playBtn_newUserForm.Location = new System.Drawing.Point(955, 554);
            this.playBtn_newUserForm.Name = "playBtn_newUserForm";
            this.playBtn_newUserForm.Size = new System.Drawing.Size(297, 45);
            this.playBtn_newUserForm.TabIndex = 5;
            this.playBtn_newUserForm.Text = "PLAY";
            this.playBtn_newUserForm.UseVisualStyleBackColor = false;
            this.playBtn_newUserForm.Click += new System.EventHandler(this.playBtn_newUserForm_Click);
            this.playBtn_newUserForm.MouseEnter += new System.EventHandler(this.playBtn_newUserForm_MouseEnter);
            this.playBtn_newUserForm.MouseLeave += new System.EventHandler(this.playBtn_newUserForm_MouseLeave);
            // 
            // submitBtn_newUserForm
            // 
            this.submitBtn_newUserForm.BackColor = System.Drawing.Color.Transparent;
            this.submitBtn_newUserForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBtn_newUserForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn_newUserForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.submitBtn_newUserForm.ForeColor = System.Drawing.Color.Firebrick;
            this.submitBtn_newUserForm.Location = new System.Drawing.Point(462, 257);
            this.submitBtn_newUserForm.Name = "submitBtn_newUserForm";
            this.submitBtn_newUserForm.Size = new System.Drawing.Size(297, 45);
            this.submitBtn_newUserForm.TabIndex = 6;
            this.submitBtn_newUserForm.Text = "Submit";
            this.submitBtn_newUserForm.UseVisualStyleBackColor = false;
            this.submitBtn_newUserForm.Click += new System.EventHandler(this.submitBtn_newUserForm_Click);
            this.submitBtn_newUserForm.MouseEnter += new System.EventHandler(this.submitBtn_newUserForm_MouseEnter);
            this.submitBtn_newUserForm.MouseLeave += new System.EventHandler(this.submitBtn_newUserForm_MouseLeave);
            // 
            // newUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceBattle.Properties.Resources.star_wars_backgrounds_11_battleship;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 611);
            this.Controls.Add(this.submitBtn_newUserForm);
            this.Controls.Add(this.playBtn_newUserForm);
            this.Controls.Add(this.returnBtn_newUserForm);
            this.Controls.Add(this.userbameLbl_newUserForm);
            this.Controls.Add(this.usrname_textBox_newUserForm);
            this.Controls.Add(this.newUsr_newUserForm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "newUserForm";
            this.Text = "newUserForm";
            this.Load += new System.EventHandler(this.newUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newUsr_newUserForm;
        private System.Windows.Forms.TextBox usrname_textBox_newUserForm;
        private System.Windows.Forms.Label userbameLbl_newUserForm;
        private System.Windows.Forms.Button returnBtn_newUserForm;
        private System.Windows.Forms.Button playBtn_newUserForm;
        private System.Windows.Forms.Button submitBtn_newUserForm;
    }
}