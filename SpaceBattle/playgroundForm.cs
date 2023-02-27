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
    public partial class playgroundForm : Form
    {
        Random r;
        SoundPlayer s;
        ButtonEffects bfx;
        User user;
        List<Label> blastAnimation = new List<Label>();
        List<Label> blastAnimationHero = new List<Label>();
        List<PictureBox> blastSuccess = new List<PictureBox>();
        List<PictureBox> blastSuccessHero = new List<PictureBox>();

        int score;
        private int prevLvlscore { get; set; }
        public bool isDefeated { get; set; }

        public int lvl { get; set; }

        public int life { get; set; }

        public int timeleft { get; set; }

        public String returnMessage { get; set; }

        public playgroundForm()
        {
            InitializeComponent();
        }

        public playgroundForm(User user)
        {
            InitializeComponent();
            this.user = new User(user.username, user.record);

        }


        private void playgroundForm_Load(object sender, EventArgs e)
        {
            r = new Random();
            s = new SoundPlayer(SpaceBattle.Properties.Resources.imperial_march);
            s.PlayLooping();
            bfx = new ButtonEffects();
            this.Init();
            this.returnBtn_playgroundForm.Enabled = false;
        }

        // --------------- Return Button Events ---------------------
        private void returnBtn_playgroundForm_MouseEnter(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.returnBtn_playgroundForm);
        }

        private void returnBtn_playgroundForm_MouseLeave(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.returnBtn_playgroundForm);

        }

        // Go back to users form
        private void returnBtn_playgroundForm_Click(object sender, EventArgs e)
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

        // ----------------------- Ticks --------------------------------
        // tick for evil spaceship to change direction  -- need to reconsider ** check animation
        private void evilspaceshipTimer_Tick(object sender, EventArgs e)
        {
            this.evilSpaceship_playgroundForm.Location = new Point(r.Next(Width - evilSpaceship_playgroundForm.Width), evilSpaceship_playgroundForm.Location.Y);
        }

        // tick for evil spaceship to fire
        private void redFire_Timer_Tick(object sender, EventArgs e)
        {
            
            
            //blastSuccess.Add(spaceship_playgroundForm);
            checkSuccess(createShot(this.evilSpaceship_playgroundForm.Location, Color.Red, this.blastAnimation), spaceship_playgroundForm , Color.Red);

        }

        // shot animation tick
        private void shot_Tick(object sender, EventArgs e)
        {
            foreach (Label blast in blastAnimation)
            {
                blast.Location = new Point(blast.Location.X, blast.Location.Y + 100);

            }

            foreach (Label heroblast in blastAnimationHero)
            {
                heroblast.Location = new Point(heroblast.Location.X, heroblast.Location.Y - 50);
                
            }
        }

        // Life Handler Tick. Handles the termination of the game. Each second it checks if
        // the player has been defeated. 
        private void lifetime_Tick(object sender, EventArgs e)
        {
            // if player hasnt been defeated yet check his lifetime
            if (!this.isDefeated)
            {
                if (this.timeleft > 0)
                {
                    timeleft--;         // Count Down 1sec per Tick
                    
                }
                else
                {
                    this.playerDefeated();
                    this.gameOver();
                }
            }
            else
            {
                this.gameOver();
            }
                
        }

        // game over! terminate timers and move to gameover form
        private void gameOver()
        {
            // stop soundplayer
            s.Stop();
            s.Dispose();
            this.Hide();

            // stop timers
            this.evilspaceshipTimer.Stop();
            this.redFire_Timer.Stop();
            this.shot.Stop();
            this.lifetime.Stop();

            // Go to gameover form
            GameOverForm gameOverForm = new GameOverForm(this.returnMessage);
            gameOverForm.StartPosition = this.StartPosition;
            gameOverForm.Location = this.Location;
            gameOverForm.ShowDialog();
            this.Close();
        }

        private Label createShot(Point location,Color color,List<Label> list)
        {
            SoundPlayer sred = new SoundPlayer(SpaceBattle.Properties.Resources.blaster_firing);
            sred.Play();
            Label blast = new Label();
            blast.BackColor = System.Drawing.Color.Transparent;
            blast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            blast.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            blast.ForeColor = color;
            blast.Location = location;
            blast.Size = new System.Drawing.Size(14, 18);
            blast.TabIndex = 11;
            blast.Text = "|";
            blast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Controls.Add(blast);
            list.Clear();       // improves performance
            list.Add(blast);
            return blast;
            //checkSuccess(blast,color);

        }

        public void Init()
        {
            //Gameplay Initialization
            //this.user = user.ReadUser()
            this.score = 0;
            this.prevLvlscore = 0;
            this.isDefeated = false;
            this.lvl = 0;
            this.life = 100;
            this.timeleft = 60;     //sec

            this.healthPgBar_playgroundForm.Value = this.life;
            this.timelbl_playgroundForm.Text = this.timeleft.ToString();
            this.level_playgroundForm.Text = this.lvl.ToString();
            this.scoreLbl_playgroundForm.Text = this.score.ToString();

        }

        public void playerGotHit()
        {
            //SoundPlayer roar = new SoundPlayer(SpaceBattle.Properties.Resources.chewy_roar);
            //roar.PlaySync();
            //MessageBox.Show(this.life.ToString());
            if (this.life > 20)
            {
                this.life -= 20;

            }
            else
            {
                this.life = 0;
                this.playerDefeated();
            }
        }

        public void enemyGotHit()
        {
            this.score += 1;
            if (this.score - this.prevLvlscore == 10)
            {
                this.levelUp();
            }
        }

        private void levelUp()
        {
            this.lvl += 1;
            
            this.timeleft += 60 - this.score;
        }

        public void playerDefeated()
        {
            SoundPlayer s = new SoundPlayer(SpaceBattle.Properties.Resources.WilhelmScream);
            SoundPlayer sRecord = new SoundPlayer(SpaceBattle.Properties.Resources.yodalaughing);
            this.isDefeated = true;
            Data dataManager = new Data();

            if (this.score < this.user.record)
            {
                s.Play();
                this.returnMessage = String.Format("You have been Defeated! \n Score : {0} \n Personal Record: {1}", this.score, this.user.record);
            }
            else if (this.score == this.user.record)
            {
                s.Play();
                this.returnMessage = String.Format("You have been Defeated! \n That was close! \n Score : {0} \n Personal Record: {1}", this.score, this.user.record);
            }
            else
            {
                sRecord.Play();
                this.returnMessage = String.Format("You have been Defeated! \n Well Done new personal record! \n Score : {0} \n Personal Record: {1}", this.score, this.user.record);
                this.user.record = this.score;
                dataManager.writeFile(this.user);
            }
        }

        private void updateLabels_Tick(object sender, EventArgs e)
        {
            this.healthPgBar_playgroundForm.Value = this.life;
            this.level_playgroundForm.Text = this.lvl.ToString();
            this.timelbl_playgroundForm.Text = this.timeleft.ToString();
            this.scoreLbl_playgroundForm.Text = this.score.ToString();

        }

        private void playgroundForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Left"))
            {
                spaceship_playgroundForm.Location = new Point(spaceship_playgroundForm.Location.X - 50, spaceship_playgroundForm.Location.Y);
            }
            else if (e.KeyCode.ToString().Equals("Right"))
            {
                spaceship_playgroundForm.Location = new Point(spaceship_playgroundForm.Location.X + 50, spaceship_playgroundForm.Location.Y);
            }
            else if (e.KeyCode.ToString().Equals("Up"))
            {
                spaceship_playgroundForm.Location = new Point(spaceship_playgroundForm.Location.X, spaceship_playgroundForm.Location.Y - 50);
            }
            else if (e.KeyCode.ToString().Equals("Down"))
            {
                spaceship_playgroundForm.Location = new Point(spaceship_playgroundForm.Location.X, spaceship_playgroundForm.Location.Y + 50);
            }
            else if (e.KeyCode.ToString().Equals("Space"))
            {
                
                checkSuccess(createShot(spaceship_playgroundForm.Location, Color.DeepSkyBlue, this.blastAnimationHero), evilSpaceship_playgroundForm, Color.DeepSkyBlue);

            }
        }

        private void playgroundForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        
            
       

        private void checkSuccess(Label blast , PictureBox spaceship , Color color)
        {
            if ( color == Color.Red)
            {
                if (blast.Location.X >= this.spaceship_playgroundForm.Location.X
                        && blast.Location.X <= (this.spaceship_playgroundForm.Location.X + this.spaceship_playgroundForm.Width))
                {
                    
                    this.playerGotHit();
                    
                }
            }
            else
            {
                if (blast.Location.X >= this.evilSpaceship_playgroundForm.Location.X
                        && blast.Location.X <= (this.evilSpaceship_playgroundForm.Location.X + this.evilSpaceship_playgroundForm.Width))
                {
                    
                        this.enemyGotHit();
                    
                }
            }

                
        }
    }
}
