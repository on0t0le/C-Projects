using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MelodyGuess
{
    public partial class AnswerForm : Form
    {
        int ansTime;

        public AnswerForm()
        {
            InitializeComponent();
        }

        private void AnswerForm_Load(object sender, EventArgs e)
        {
            ansTime = 10;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ansTime--;
            lAnsTime.Text = ansTime.ToString();
            if (ansTime == 0)
            {
                timer1.Stop();
                SoundPlayer sp = new SoundPlayer("Resources\\microwave-oven-bell-1.wav");
                sp.Play();
            }
        }

        private void AnswerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var audio = TagLib.File.Create(GameEngine.answer);
            label1.Text = audio.Tag.FirstAlbumArtist + " - " + audio.Tag.Title;
        }
    }
}
