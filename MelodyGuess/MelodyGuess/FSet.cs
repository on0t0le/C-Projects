using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MelodyGuess
{
    public partial class FSet : Form
    {
        public FSet()
        {
            InitializeComponent();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            GameEngine.innerFolder = cbDirectories.Checked;
            GameEngine.gameTime = Convert.ToInt32(cbGameTime.Text);
            GameEngine.musicTime = Convert.ToInt32(cbMusicTime.Text);
            GameEngine.randStart = cbRandStart.Checked;
            GameEngine.pl1Key = cbPl1.Text;
            GameEngine.pl2Key = cbPl2.Text;
            GameEngine.WriteParam();
            this.Hide();
        }

        void Set()
        {
            cbDirectories.Checked = GameEngine.innerFolder;
            cbGameTime.Text = GameEngine.gameTime.ToString();
            cbMusicTime.Text = GameEngine.musicTime.ToString();
            cbRandStart.Checked = GameEngine.randStart;
            cbPl1.Text = GameEngine.pl1Key;
            cbPl2.Text = GameEngine.pl2Key;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Set();
            this.Hide();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog()==DialogResult.OK)
            {
                string[] mlist = Directory.GetFiles(fbd.SelectedPath, "*.mp3",cbDirectories.Checked?SearchOption.AllDirectories:SearchOption.TopDirectoryOnly);
                GameEngine.lastFolder = fbd.SelectedPath;
                listBox1.Items.Clear();
                listBox1.Items.AddRange(mlist);
                GameEngine.mList.Clear();
                GameEngine.mList.AddRange(mlist);
            }
        }

        private void bClrList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void FSet_Load(object sender, EventArgs e)
        {
            Set();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(GameEngine.mList.ToArray());
        }
    }
}
