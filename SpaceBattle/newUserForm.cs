/* Grigoris Karaoglanian - p16044 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceBattle
{
    public partial class newUserForm : Form
    {
        SoundPlayer s;
        ButtonEffects bfx;
        User user;
        Data dataManager;
        public newUserForm()
        {
            InitializeComponent();
        }

        private void newUserForm_Load(object sender, EventArgs e)
        {
            s = new SoundPlayer(SpaceBattle.Properties.Resources.force);
            bfx = new ButtonEffects();
            this.playBtn_newUserForm.Enabled = false;
            this.submitBtn_newUserForm.Enabled = false;
            dataManager = new Data();
        }

        // ------------------ Return Button Events --------------------------

        private void returnBtn_newUserForm_MouseEnter(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.returnBtn_newUserForm);
        }

        private void returnBtn_newUserForm_MouseLeave(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.returnBtn_newUserForm);
        }

        private void returnBtn_newUserForm_Click(object sender, EventArgs e)
        {
            bfx.returnButtonSound();
            this.Hide();
            WelcomeForm WelcomeForm = new WelcomeForm();
            WelcomeForm.StartPosition = this.StartPosition;
            WelcomeForm.Location = this.Location;
            WelcomeForm.ShowDialog();
            this.Close();
        }

        // -------------------- Submit Button Events --------------------------
        private void submitBtn_newUserForm_MouseEnter(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.submitBtn_newUserForm);
        }

        private void submitBtn_newUserForm_MouseLeave(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.submitBtn_newUserForm);
        }

        private void submitBtn_newUserForm_Click(object sender, EventArgs e)
        {
            s.Play();
            this.playBtn_newUserForm.Enabled = true;
            user = new User();
            user.username = usrname_textBox_newUserForm.Text;
            user.record = 0;
            dataManager.writeFile(user);
        }

        // ----------------- Play Button Events ------------------------

        private void playBtn_newUserForm_MouseEnter(object sender, EventArgs e)
        {
            if (this.playBtn_newUserForm.Enabled) bfx.reverseButtonColor(this.playBtn_newUserForm);
        }

        private void playBtn_newUserForm_MouseLeave(object sender, EventArgs e)
        {
            if (this.playBtn_newUserForm.Enabled) bfx.reverseButtonColor(this.playBtn_newUserForm);
        }

        private void playBtn_newUserForm_Click(object sender, EventArgs e)
        {
            s.Stop();
            s.Dispose();
            bfx.playButtonSound();
            this.Hide();
            playgroundForm playgroundForm = new playgroundForm(this.user);
            playgroundForm.StartPosition = this.StartPosition;
            playgroundForm.Location = this.Location;
            playgroundForm.ShowDialog();
            this.Close();
        }

        // empty username is not allowed
        private void usrname_textBox_newUserForm_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(usrname_textBox_newUserForm.Text))
            {
                submitBtn_newUserForm.Enabled = true;
            } else
            {
                submitBtn_newUserForm.Enabled = false;

            }
        }
    }
}
