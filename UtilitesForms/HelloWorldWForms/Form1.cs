using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;

namespace HelloWorldWForms
{
    public partial class MainForm : Form
    {

        int counter = 0;
        Random rand;
        char[] symb = new char[] { '#', '@', '$', '%', '&', '?'};
        Dictionary<string, double> metrical;

        public MainForm()
        {
            
            InitializeComponent();
            rand = new Random();
            metrical = new Dictionary<string, double>();
            

        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program 'My utilites' that consists of differ programs\nAuthor: Anatolii","About");
        }

        private void bPlus_Click(object sender, EventArgs e)
        {
            counter++;
            lCounter.Text = counter.ToString();
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                counter = 0;
            }
            else if (counter > 0)
            {
                counter--;
                lCounter.Text = counter.ToString();
            }
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            counter = 0;
            lCounter.Text = counter.ToString();

        }

        private void bGenerate_Click(object sender, EventArgs e)
        {
            int n;
            n = rand.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value)+1);
            lRandom.Text = n.ToString();
            if (cbRandom.Checked)
            {
            if(tbRandom.Text.IndexOf(n.ToString())==-1) tbRandom.AppendText(n + "\n");
            }
            else tbRandom.AppendText(n + "\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRandom.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbRandom.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tsmiInsDate_Click(object sender, EventArgs e)
        {
            rtbNote.AppendText(DateTime.Now.ToShortDateString()+"\n");
        }

        private void tsmiInsTime_Click(object sender, EventArgs e)
        {
            rtbNote.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
            rtbNote.SaveFile("note.rtf");
            }
            catch
            {
                MessageBox.Show("Error while saving!");
            }
        }

        void LoadFile()
        {
            try
            {

                rtbNote.LoadFile("note.rtf");
            }
            catch
            {
                MessageBox.Show("File not found!");
            }
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadFile();
            clbPass.SetItemChecked(0, true);
            
        }

        private void bGenPass_Click(object sender, EventArgs e)
        {
            if (clbPass.CheckedItems.Count == 0) return;
            String password = null;
            for(int i =0; i < passLenth.Value; i++)
            {
                int n = rand.Next(0, clbPass.CheckedItems.Count);
                String s = clbPass.CheckedItems[n].ToString();
                switch (s)
                {
                    case "Numbers" : password += rand.Next(10).ToString();
                        break;
                    case "Leters":
                        password += Convert.ToChar(rand.Next(97, 122));                        
                        break;
                    case "Big leters":
                        password += Convert.ToChar(rand.Next(65, 88));
                        break;
                    default:
                        password +=symb[rand.Next(symb.Length)];
                        break;

                }
                tbPass.Text= password;
            }
        }

        private void bClrPass_Click(object sender, EventArgs e)
        {
            tbPass.Clear();
        }

        private void bCopyPass_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbPass.Text);
        }

        private void bConvert_Click(object sender, EventArgs e)
        {
            double m1 = metrical[cbFrom.Text];
            double m2 = metrical[cbTo.Text];
            double n = Convert.ToDouble(valFrom.Text);
            valTo.Text = (n * m1 / m2).ToString();
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            string t = cbFrom.Text;
            cbFrom.Text = cbTo.Text;
            cbTo.Text = t;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbMetric.Text)
            {
                case "Length":
                    //download metricals into dictionary
                    metrical.Clear();
                    metrical.Add("mm", 1);
                    metrical.Add("cm", 10);
                    metrical.Add("dm", 100);
                    metrical.Add("m", 1000);
                    metrical.Add("km", 1000000);
                    metrical.Add("mile", 1609344);
                    //download items in boxes From
                    cbFrom.Items.Clear();
                    cbFrom.Items.Add("mm");
                    cbFrom.Items.Add("sm");
                    cbFrom.Items.Add("dm");
                    cbFrom.Items.Add("m");
                    cbFrom.Items.Add("km");
                    cbFrom.Items.Add("mile");
                    //download items in boxes To
                    cbTo.Items.Clear();
                    cbTo.Items.Add("mm");
                    cbTo.Items.Add("sm");
                    cbTo.Items.Add("dm");
                    cbTo.Items.Add("m");
                    cbTo.Items.Add("km");
                    cbTo.Items.Add("mile");
                    //set default values
                    cbFrom.Text = "mm";
                    cbTo.Text = "mm";
                    break;
                case "Weight":
                    //download metricals into dictionary
                    metrical.Clear();
                    metrical.Add("g", 1);
                    metrical.Add("kg", 1000);
                    metrical.Add("t", 1000000);
                    metrical.Add("lb", 453.6);
                    //download items in boxes From
                    cbFrom.Items.Clear();
                    cbFrom.Items.Add("g");
                    cbFrom.Items.Add("kg");
                    cbFrom.Items.Add("t");
                    cbFrom.Items.Add("lb");
                    //download items in boxes To
                    cbTo.Items.Clear();
                    cbTo.Items.Add("g");
                    cbTo.Items.Add("kg");
                    cbTo.Items.Add("t");
                    cbTo.Items.Add("lb");                    
                    //set default values
                    cbFrom.Text = "g";
                    cbTo.Text = "g";
                    break;
                default:
                    break;
            }
        }

        
    }
}
