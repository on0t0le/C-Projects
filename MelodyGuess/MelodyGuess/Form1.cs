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
    public partial class fMain : Form
    {
        FSet fs = new FSet();
        FGame fg = new FGame();

        public fMain()
        {
            InitializeComponent();
            
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bSet_Click(object sender, EventArgs e)
        {            
            fs.ShowDialog();
        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            fg.ShowDialog();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            GameEngine.ReadParam();
            GameEngine.MusicLoad();
        }
    }
}
