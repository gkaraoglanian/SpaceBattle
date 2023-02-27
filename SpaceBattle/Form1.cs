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
    public partial class WelcomeForm : Form
    {
        SoundPlayer s ;
        ButtonEffects bfx;
        //DataManager dataManager;
        

        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            s = new SoundPlayer(SpaceBattle.Properties.Resources.imperial_march);
            s.PlayLooping();
            bfx = new ButtonEffects();
            /*dataManager = new DataManager();
            //dataManager.setDirectory("users);
            
            if (!dataManager.anyUsers())
            {
                // Must register as a new user
                this.usersButton.Enabled = false;
                this.recordsButton.Enabled = false;
            }*/
            
        }

        // ------------- Users Button Events ---------------------
        private void userButton_MouseLeave(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.usersButton);
        }

        private void usersButton_MouseEnter(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.usersButton);
        }
        private void usersButton_Click(object sender, EventArgs e)
        {
            bfx.playButtonSound();
            s.Stop();
            s.Dispose();
            this.Hide();
            UsersForm UsersForm = new UsersForm();
            UsersForm.StartPosition = this.StartPosition;
            UsersForm.Location = this.Location;
            UsersForm.ShowDialog();
            this.Close();

        }

        //----------------- Records Button Events ----------------------
        private void recordsButton_MouseEnter(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.recordsButton);
        }

        private void recordsButton_MouseLeave(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.recordsButton);
        }
        private void recordsButton_Click(object sender, EventArgs e)
        {
            bfx.playButtonSound();
            s.Stop();
            s.Dispose();
            this.Hide();
            RecordsForm RecordsForm = new RecordsForm();
            RecordsForm.StartPosition = this.StartPosition;
            RecordsForm.Location = this.Location;
            RecordsForm.ShowDialog();
            this.Close();
        }

        //-------------------- New users Button Events -------------------
        private void newUserButton_MouseEnter(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.newUserButton);
        }

        private void newUserButton_MouseLeave(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.newUserButton);

        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            bfx.playButtonSound();
            s.Stop();
            s.Dispose();
            this.Hide();
            newUserForm newUserForm = new newUserForm();
            //newUserForm.StartPosition = FormStartPosition.CenterScreen;
            newUserForm.StartPosition = this.StartPosition;
            newUserForm.Location = this.Location;
            newUserForm.ShowDialog();
            this.Close();
        }
    }
}
