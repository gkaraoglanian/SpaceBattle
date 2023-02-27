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
    public partial class RecordsForm : Form
    {
        SoundPlayer s;
        ButtonEffects bfx;
        Data dataManager;
        public RecordsForm()
        {
            InitializeComponent();
        }

        private void RecordsForm_Load(object sender, EventArgs e)
        {
            s = new SoundPlayer(SpaceBattle.Properties.Resources.light_saber_battle);
            s.PlayLooping();
            bfx = new ButtonEffects();
            dataManager = new Data();
            this.recordsListBox_RecordsForm.DataSource = dataManager.readAllUsers();
        }

        private void returnBtn_RecordsForm_MouseEnter(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.returnBtn_RecordsForm);
        }
        private void returnBtn_RecordsForm_MouseLeave(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.returnBtn_RecordsForm);

        }

        private void returnBtn_RecordsForm_Click(object sender, EventArgs e)
        {
            bfx.returnButtonSound();
            s.Stop();
            s.Dispose();
            this.Hide();
            WelcomeForm WelcomeForm = new WelcomeForm();
            WelcomeForm.StartPosition = this.StartPosition;
            WelcomeForm.Location = this.Location;
            WelcomeForm.ShowDialog();
            this.Close();
        }

       
    }
}
