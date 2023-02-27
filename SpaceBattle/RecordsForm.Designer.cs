namespace SpaceBattle
{
    partial class RecordsForm
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
            this.recordsLabel_RecordsForm = new System.Windows.Forms.Label();
            this.returnBtn_RecordsForm = new System.Windows.Forms.Button();
            this.recordsListBox_RecordsForm = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // recordsLabel_RecordsForm
            // 
            this.recordsLabel_RecordsForm.BackColor = System.Drawing.Color.Transparent;
            this.recordsLabel_RecordsForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.recordsLabel_RecordsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordsLabel_RecordsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.recordsLabel_RecordsForm.ForeColor = System.Drawing.Color.Yellow;
            this.recordsLabel_RecordsForm.Location = new System.Drawing.Point(0, 0);
            this.recordsLabel_RecordsForm.Name = "recordsLabel_RecordsForm";
            this.recordsLabel_RecordsForm.Size = new System.Drawing.Size(1264, 57);
            this.recordsLabel_RecordsForm.TabIndex = 0;
            this.recordsLabel_RecordsForm.Text = "Records";
            this.recordsLabel_RecordsForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // returnBtn_RecordsForm
            // 
            this.returnBtn_RecordsForm.BackColor = System.Drawing.Color.Transparent;
            this.returnBtn_RecordsForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBtn_RecordsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn_RecordsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.returnBtn_RecordsForm.ForeColor = System.Drawing.Color.Yellow;
            this.returnBtn_RecordsForm.Location = new System.Drawing.Point(10, 554);
            this.returnBtn_RecordsForm.Name = "returnBtn_RecordsForm";
            this.returnBtn_RecordsForm.Size = new System.Drawing.Size(297, 45);
            this.returnBtn_RecordsForm.TabIndex = 3;
            this.returnBtn_RecordsForm.Text = "Return";
            this.returnBtn_RecordsForm.UseVisualStyleBackColor = false;
            this.returnBtn_RecordsForm.Click += new System.EventHandler(this.returnBtn_RecordsForm_Click);
            this.returnBtn_RecordsForm.MouseEnter += new System.EventHandler(this.returnBtn_RecordsForm_MouseEnter);
            this.returnBtn_RecordsForm.MouseLeave += new System.EventHandler(this.returnBtn_RecordsForm_MouseLeave);
            // 
            // recordsListBox_RecordsForm
            // 
            this.recordsListBox_RecordsForm.BackColor = System.Drawing.Color.Black;
            this.recordsListBox_RecordsForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recordsListBox_RecordsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.recordsListBox_RecordsForm.ForeColor = System.Drawing.Color.Yellow;
            this.recordsListBox_RecordsForm.FormattingEnabled = true;
            this.recordsListBox_RecordsForm.ItemHeight = 29;
            this.recordsListBox_RecordsForm.Location = new System.Drawing.Point(501, 122);
            this.recordsListBox_RecordsForm.Name = "recordsListBox_RecordsForm";
            this.recordsListBox_RecordsForm.Size = new System.Drawing.Size(263, 290);
            this.recordsListBox_RecordsForm.TabIndex = 4;
            // 
            // RecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceBattle.Properties.Resources.star_wars_backgrounds_14_ligthspeed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 611);
            this.Controls.Add(this.recordsListBox_RecordsForm);
            this.Controls.Add(this.returnBtn_RecordsForm);
            this.Controls.Add(this.recordsLabel_RecordsForm);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecordsForm";
            this.Text = "RecordsForm";
            this.Load += new System.EventHandler(this.RecordsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label recordsLabel_RecordsForm;
        private System.Windows.Forms.Button returnBtn_RecordsForm;
        private System.Windows.Forms.ListBox recordsListBox_RecordsForm;
    }
}