namespace SpaceBattle
{
    partial class playgroundForm
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
            this.returnBtn_playgroundForm = new System.Windows.Forms.Button();
            this.lifeLbl_playgroundForm = new System.Windows.Forms.Label();
            this.healthPgBar_playgroundForm = new System.Windows.Forms.ProgressBar();
            this.scoreLbl_playgroundForm = new System.Windows.Forms.Label();
            this.lvlLabel_playgroundForm = new System.Windows.Forms.Label();
            this.level_playgroundForm = new System.Windows.Forms.Label();
            this.timelbl_playgroundForm = new System.Windows.Forms.Label();
            this.spaceship_playgroundForm = new System.Windows.Forms.PictureBox();
            this.evilSpaceship_playgroundForm = new System.Windows.Forms.PictureBox();
            this.evilspaceshipTimer = new System.Windows.Forms.Timer(this.components);
            this.redFire_Timer = new System.Windows.Forms.Timer(this.components);
            this.shot = new System.Windows.Forms.Timer(this.components);
            this.lifetime = new System.Windows.Forms.Timer(this.components);
            this.updateLabels = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spaceship_playgroundForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evilSpaceship_playgroundForm)).BeginInit();
            this.SuspendLayout();
            // 
            // returnBtn_playgroundForm
            // 
            this.returnBtn_playgroundForm.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.returnBtn_playgroundForm.BackColor = System.Drawing.Color.Transparent;
            this.returnBtn_playgroundForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.returnBtn_playgroundForm.CausesValidation = false;
            this.returnBtn_playgroundForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.returnBtn_playgroundForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.returnBtn_playgroundForm.ForeColor = System.Drawing.Color.Lime;
            this.returnBtn_playgroundForm.Location = new System.Drawing.Point(2, 1);
            this.returnBtn_playgroundForm.Margin = new System.Windows.Forms.Padding(0);
            this.returnBtn_playgroundForm.Name = "returnBtn_playgroundForm";
            this.returnBtn_playgroundForm.Size = new System.Drawing.Size(34, 31);
            this.returnBtn_playgroundForm.TabIndex = 0;
            this.returnBtn_playgroundForm.Text = "<";
            this.returnBtn_playgroundForm.UseVisualStyleBackColor = false;
            this.returnBtn_playgroundForm.Click += new System.EventHandler(this.returnBtn_playgroundForm_Click);
            this.returnBtn_playgroundForm.MouseEnter += new System.EventHandler(this.returnBtn_playgroundForm_MouseEnter);
            this.returnBtn_playgroundForm.MouseLeave += new System.EventHandler(this.returnBtn_playgroundForm_MouseLeave);
            // 
            // lifeLbl_playgroundForm
            // 
            this.lifeLbl_playgroundForm.BackColor = System.Drawing.Color.Transparent;
            this.lifeLbl_playgroundForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lifeLbl_playgroundForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lifeLbl_playgroundForm.ForeColor = System.Drawing.Color.White;
            this.lifeLbl_playgroundForm.Location = new System.Drawing.Point(152, 572);
            this.lifeLbl_playgroundForm.Name = "lifeLbl_playgroundForm";
            this.lifeLbl_playgroundForm.Size = new System.Drawing.Size(40, 30);
            this.lifeLbl_playgroundForm.TabIndex = 1;
            this.lifeLbl_playgroundForm.Text = "Life";
            this.lifeLbl_playgroundForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // healthPgBar_playgroundForm
            // 
            this.healthPgBar_playgroundForm.BackColor = System.Drawing.Color.White;
            this.healthPgBar_playgroundForm.ForeColor = System.Drawing.Color.Green;
            this.healthPgBar_playgroundForm.Location = new System.Drawing.Point(198, 572);
            this.healthPgBar_playgroundForm.Name = "healthPgBar_playgroundForm";
            this.healthPgBar_playgroundForm.Size = new System.Drawing.Size(140, 30);
            this.healthPgBar_playgroundForm.Step = 20;
            this.healthPgBar_playgroundForm.TabIndex = 2;
            this.healthPgBar_playgroundForm.Value = 20;
            // 
            // scoreLbl_playgroundForm
            // 
            this.scoreLbl_playgroundForm.BackColor = System.Drawing.Color.Transparent;
            this.scoreLbl_playgroundForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scoreLbl_playgroundForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.scoreLbl_playgroundForm.ForeColor = System.Drawing.Color.Yellow;
            this.scoreLbl_playgroundForm.Location = new System.Drawing.Point(525, 547);
            this.scoreLbl_playgroundForm.Name = "scoreLbl_playgroundForm";
            this.scoreLbl_playgroundForm.Size = new System.Drawing.Size(276, 55);
            this.scoreLbl_playgroundForm.TabIndex = 4;
            this.scoreLbl_playgroundForm.Text = "0";
            this.scoreLbl_playgroundForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvlLabel_playgroundForm
            // 
            this.lvlLabel_playgroundForm.BackColor = System.Drawing.Color.Transparent;
            this.lvlLabel_playgroundForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lvlLabel_playgroundForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lvlLabel_playgroundForm.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lvlLabel_playgroundForm.Location = new System.Drawing.Point(1133, 572);
            this.lvlLabel_playgroundForm.Name = "lvlLabel_playgroundForm";
            this.lvlLabel_playgroundForm.Size = new System.Drawing.Size(51, 30);
            this.lvlLabel_playgroundForm.TabIndex = 5;
            this.lvlLabel_playgroundForm.Text = "LVL";
            this.lvlLabel_playgroundForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // level_playgroundForm
            // 
            this.level_playgroundForm.BackColor = System.Drawing.Color.Transparent;
            this.level_playgroundForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.level_playgroundForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.level_playgroundForm.ForeColor = System.Drawing.Color.DarkMagenta;
            this.level_playgroundForm.Location = new System.Drawing.Point(1190, 566);
            this.level_playgroundForm.Name = "level_playgroundForm";
            this.level_playgroundForm.Size = new System.Drawing.Size(51, 36);
            this.level_playgroundForm.TabIndex = 6;
            this.level_playgroundForm.Text = "0";
            this.level_playgroundForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timelbl_playgroundForm
            // 
            this.timelbl_playgroundForm.BackColor = System.Drawing.Color.Transparent;
            this.timelbl_playgroundForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timelbl_playgroundForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.timelbl_playgroundForm.ForeColor = System.Drawing.Color.White;
            this.timelbl_playgroundForm.Location = new System.Drawing.Point(830, 547);
            this.timelbl_playgroundForm.Name = "timelbl_playgroundForm";
            this.timelbl_playgroundForm.Size = new System.Drawing.Size(164, 55);
            this.timelbl_playgroundForm.TabIndex = 7;
            this.timelbl_playgroundForm.Text = "00:00";
            this.timelbl_playgroundForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spaceship_playgroundForm
            // 
            this.spaceship_playgroundForm.BackColor = System.Drawing.Color.Transparent;
            this.spaceship_playgroundForm.BackgroundImage = global::SpaceBattle.Properties.Resources.spcc1566_2956386308_2;
            this.spaceship_playgroundForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spaceship_playgroundForm.Location = new System.Drawing.Point(424, 459);
            this.spaceship_playgroundForm.Name = "spaceship_playgroundForm";
            this.spaceship_playgroundForm.Size = new System.Drawing.Size(94, 52);
            this.spaceship_playgroundForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spaceship_playgroundForm.TabIndex = 8;
            this.spaceship_playgroundForm.TabStop = false;
            // 
            // evilSpaceship_playgroundForm
            // 
            this.evilSpaceship_playgroundForm.BackColor = System.Drawing.Color.Transparent;
            this.evilSpaceship_playgroundForm.BackgroundImage = global::SpaceBattle.Properties.Resources.evilspaceship_1775014896_2;
            this.evilSpaceship_playgroundForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.evilSpaceship_playgroundForm.Location = new System.Drawing.Point(558, 26);
            this.evilSpaceship_playgroundForm.Name = "evilSpaceship_playgroundForm";
            this.evilSpaceship_playgroundForm.Size = new System.Drawing.Size(94, 52);
            this.evilSpaceship_playgroundForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.evilSpaceship_playgroundForm.TabIndex = 9;
            this.evilSpaceship_playgroundForm.TabStop = false;
            // 
            // evilspaceshipTimer
            // 
            this.evilspaceshipTimer.Enabled = true;
            this.evilspaceshipTimer.Interval = 2000;
            this.evilspaceshipTimer.Tick += new System.EventHandler(this.evilspaceshipTimer_Tick);
            // 
            // redFire_Timer
            // 
            this.redFire_Timer.Enabled = true;
            this.redFire_Timer.Interval = 3000;
            this.redFire_Timer.Tick += new System.EventHandler(this.redFire_Timer_Tick);
            // 
            // shot
            // 
            this.shot.Enabled = true;
            this.shot.Interval = 10;
            this.shot.Tick += new System.EventHandler(this.shot_Tick);
            // 
            // lifetime
            // 
            this.lifetime.Enabled = true;
            this.lifetime.Interval = 1000;
            this.lifetime.Tick += new System.EventHandler(this.lifetime_Tick);
            // 
            // updateLabels
            // 
            this.updateLabels.Enabled = true;
            this.updateLabels.Tick += new System.EventHandler(this.updateLabels_Tick);
            // 
            // playgroundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceBattle.Properties.Resources.star_wars_backgrounds_25_starfield;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 611);
            this.Controls.Add(this.evilSpaceship_playgroundForm);
            this.Controls.Add(this.spaceship_playgroundForm);
            this.Controls.Add(this.timelbl_playgroundForm);
            this.Controls.Add(this.level_playgroundForm);
            this.Controls.Add(this.lvlLabel_playgroundForm);
            this.Controls.Add(this.scoreLbl_playgroundForm);
            this.Controls.Add(this.healthPgBar_playgroundForm);
            this.Controls.Add(this.lifeLbl_playgroundForm);
            this.Controls.Add(this.returnBtn_playgroundForm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "playgroundForm";
            this.Text = "playgroundForm";
            this.Load += new System.EventHandler(this.playgroundForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.playgroundForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.playgroundForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.spaceship_playgroundForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evilSpaceship_playgroundForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button returnBtn_playgroundForm;
        private System.Windows.Forms.Label lifeLbl_playgroundForm;
        private System.Windows.Forms.ProgressBar healthPgBar_playgroundForm;
        private System.Windows.Forms.Label scoreLbl_playgroundForm;
        private System.Windows.Forms.Label lvlLabel_playgroundForm;
        private System.Windows.Forms.Label level_playgroundForm;
        private System.Windows.Forms.Label timelbl_playgroundForm;
        private System.Windows.Forms.PictureBox spaceship_playgroundForm;
        private System.Windows.Forms.PictureBox evilSpaceship_playgroundForm;
        private System.Windows.Forms.Timer evilspaceshipTimer;
        private System.Windows.Forms.Timer redFire_Timer;
        private System.Windows.Forms.Timer shot;
        private System.Windows.Forms.Timer lifetime;
        private System.Windows.Forms.Timer updateLabels;
    }
}