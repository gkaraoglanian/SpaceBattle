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
    public partial class GameOverForm : Form
    {

        SoundPlayer s;
        ButtonEffects bfx;
        String message;

        public GameOverForm()
        {
            InitializeComponent();
        }
        public GameOverForm(String message)
        {
            InitializeComponent();
            this.message = message;
        }
        private void GameOverForm_Load(object sender, EventArgs e)
        {
            s = new SoundPlayer(SpaceBattle.Properties.Resources.imperial_march);
            //gameplay = new Gameplay();
            bfx = new ButtonEffects();
            this.gameOverLabel.Text = this.message;
        }

        // ------------------Return Button Effects-----------------
        private void returnBtn_gameOverForm_MouseEnter(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.returnBtn_gameOverForm);
        }

        private void returnBtn_gameOverForm_MouseLeave(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.returnBtn_gameOverForm);
        }

        private void returnBtn_gameOverForm_Click(object sender, EventArgs e)
        {
            s.Stop();
            s.Dispose();
            bfx.returnButtonSound();
            // Go to UsersForm
            this.Hide();
            UsersForm UsersForm = new UsersForm();
            UsersForm.StartPosition = this.StartPosition;
            UsersForm.Location = this.Location;
            UsersForm.ShowDialog();
            this.Close();
        }
    }
}
