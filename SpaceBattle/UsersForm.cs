/* Grigoris Karaoglanian - p16044 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceBattle
{
    public partial class UsersForm : Form
    {
        
        ButtonEffects bfx;
        User user;
        Data dataManager;

        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            bfx = new ButtonEffects();
            
            user = new User();
            this.playButton_UsersForm.Enabled = false;
            dataManager = new Data();
            
            //this.UserslistBox.Items.AddRange(new object[] { "User" });
            //this.UserslistBox.Items.Add(this.user);
            UserslistBox.DataSource = dataManager.readAllUsers();
        }

        //------------------ Return Button Events -------------------------

        private void returnButton_UsersForm_MouseEnter(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.returnButton_UsersForm);           
        }

        private void returnButton_UsersForm_MouseLeave(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.returnButton_UsersForm);           

        }

        private void returnButton_UsersForm_Click(object sender, EventArgs e)
        {
            bfx.returnButtonSound();
            this.Hide();
            WelcomeForm WelcomeForm = new WelcomeForm();
            WelcomeForm.StartPosition = this.StartPosition;
            WelcomeForm.Location = this.Location;
            WelcomeForm.ShowDialog();
            this.Close();
        }

        // ----------------- Play Button Events ----------------------------

        private void playButton_UsersForm_MouseEnter(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.playButton_UsersForm);

        }

        private void playButton_UsersForm_MouseLeave(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.playButton_UsersForm);
        }

        private void playButton_UsersForm_Click(object sender, EventArgs e)
        {
            bfx.playButtonSound();
            this.Hide();
            playgroundForm playgroundForm = new playgroundForm(this.user);
            playgroundForm.StartPosition = this.StartPosition;
            playgroundForm.Location = this.Location;
            playgroundForm.ShowDialog();
            this.Close();
        }

        //---------------- ListBox Events --------------------------
        private void UserslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.playButton_UsersForm.Enabled = true;

            try
            {
                this.user = dataManager.userFormat(this.UserslistBox.SelectedItem.ToString());
            }
            catch(Exception f)      //debugging -- if doesnt work use dataManager userFormat to reverse from string
            {
                Console.WriteLine("The process failed: {0}", f.ToString());
            }
            finally { }
        }
            
        
    }
}
