using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelodyGuess
{
    public partial class FGame : Form
    {
        Random rand = new Random();
        int musicTime = GameEngine.musicTime;
        bool[] players = new bool[2];

        public FGame()
        {
            InitializeComponent();
        }

        void nextMusic()
        {
            if (GameEngine.mList.Count!=0 && progressBar1.Value != progressBar1.Maximum)
            {
                label3.Text = (GameEngine.mList.Count-1).ToString();
                musicTime = GameEngine.musicTime;
                players[0] = false;
                players[1] = false;

                int n = rand.Next(0, GameEngine.mList.Count);
                wmp.URL = GameEngine.mList[n];
                GameEngine.answer = wmp.URL;
                //wmp.Ctlcontrols.play();
                GameEngine.mList.RemoveAt(n);
            }
            else
            {
                EndGame();
                if(MessageBox.Show("Restart game?","Do you want to restart game?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    LoadNewGame();
                }
                else this.Close();
            }
            
        }


        private void bNext_Click(object sender, EventArgs e)
        {
            timer1.Start();
            nextMusic();


        }

        private void FGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            wmp.Ctlcontrols.stop();
        }
                
        private void FGame_Load(object sender, EventArgs e)
        {
            LoadNewGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            musicTime--;
            lbMusicTime.Text = musicTime.ToString();

            if (progressBar1.Value == progressBar1.Maximum)
            {
                EndGame();
                return;
            }
            if (musicTime == 0) PauseGame();
        }

        private void bPause_Click(object sender, EventArgs e)
        {
            PauseGame();
        }

        private void bContinue_Click(object sender, EventArgs e)
        {  
            if (progressBar1.Value != progressBar1.Maximum && progressBar1.Value != 0 && timer1.Enabled != true) PlayGame();
            else return;
        }
        
        //Catch and check user answer

        private void FGame_KeyDown(object sender, KeyEventArgs e)
        {
            //if (timer1.Enabled == false) return;
            if (progressBar1.Value==0) return;
            if (players[0]==false && Convert.ToString(e.KeyData) == GameEngine.pl1Key)
            {
                PauseGame();
                AnswerForm af = new AnswerForm();
                af.lMessage.Text = "Player 1";
                players[0] = true;
                if(af.ShowDialog() == DialogResult.Yes)
                {
                    lbScore1.Text = Convert.ToString(Convert.ToInt32(lbScore1.Text) + 1);
                    nextMusic();
                }              
               PlayGame();
                
            }
            if (players[1] == false && Convert.ToString(e.KeyData) == GameEngine.pl2Key)
            {
                PauseGame();
                AnswerForm af = new AnswerForm();
                af.lMessage.Text = "Player 2";
                players[1] = true;
                if (af.ShowDialog() == DialogResult.Yes)
                {
                    lbScore2.Text = Convert.ToString(Convert.ToInt32(lbScore2.Text) + 1);
                    nextMusic();
                }                
                PlayGame();
            }
        }

        //Game control functions

        void LoadNewGame()
        {
            GameEngine.MusicLoad();
            label3.Text = GameEngine.mList.Count.ToString();
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = GameEngine.gameTime;
            lbMusicTime.Text = musicTime.ToString();
        }
        void PlayGame()
        {
            musicTime = GameEngine.musicTime;
            timer1.Start();
            wmp.Ctlcontrols.play();            
        }
        void EndGame()
        {
            timer1.Stop();
            wmp.Ctlcontrols.stop();
        }
        void PauseGame()
        {
            timer1.Stop();
            wmp.Ctlcontrols.pause();
        }

        //random music start

        private void wmp_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (GameEngine.randStart)
                if (wmp.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                    wmp.Ctlcontrols.currentPosition = rand.Next(0, (int)wmp.currentMedia.duration / 2);
        }

        //manual score changing

        private void lbScore1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left) (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) + 1);
            if (e.Button == MouseButtons.Right) (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) - 1);
        }
    }
}
