/* Grigoris Karaoglanian - p16044 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceBattle
{
    class ButtonEffects:Button
    {
        SoundPlayer s;
        public void reverseButtonColor(Button btn)
        {
            //Color bgc, Color fc
            Color reverseclr = btn.BackColor;     //BACKGROUND COLOR
            btn.BackColor = btn.ForeColor;
            btn.ForeColor = reverseclr;

        }

        public void playButtonSound()
        {
            // Play on button click
            s = new SoundPlayer(SpaceBattle.Properties.Resources.light_saber_on);
            s.PlaySync();
            //this.s.Dispose();
        }

        public void returnButtonSound()
        {
            // Play on button click
            s = new SoundPlayer(SpaceBattle.Properties.Resources.light_saber_off);
            s.PlaySync();
        }
    }
}
