using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCFS_ex
{
    public partial class Form1 : Form
    {
        private Data[] data;
        struct Data
        {
            public string name;
            public int arriv, dur, wait, done, start, TA;
            
        }
        public Form1()
        {
            InitializeComponent();
            data = new Data[0];
            listview();
        }
        private void listview()
        {
            LV.Clear();
            LV.View = View.Details;
            LV.Columns.Add("Name of process", 80);
            LV.Columns.Add("Arriving time", 80); 
            LV.Columns.Add("Duration of Execution", 80); 
            LV.Columns.Add("Start", 80); 
            LV.Columns.Add("Done", 80); 
            LV.Columns.Add("Wait", 80); 
            LV.Columns.Add("TA", 80);
            LV.GridLines = true;
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); int arriv, dur;
            if (txtJlhproses.Text == "")
                MessageBox.Show("Input Number of Processes!");
            else
            {
                for(int i = 0; i < int.Parse(txtJlhproses.Text); i++)
                {
                    Array.Resize(ref data, data.Length + 1);
                    arriv = rnd.Next(1, 30);
                    dur = rnd.Next(1, 30);
                    LV.Items.Add(data[data.GetUpperBound(0)].name = "Proses - " + (i + 1));
                    LV.Items[LV.Items.Count - 1].SubItems.Add(Convert.ToString((data[data.GetUpperBound(0)].arriv = arriv)));
                    LV.Items[LV.Items.Count - 1].SubItems.Add(Convert.ToString((data[data.GetUpperBound(0)].dur = dur)));
                }
                txtJlhproses.ResetText();
            }
        }

        private void btnfcfs_Click(object sender, EventArgs e)
        {
            listview();
            int WT, LE;
            string NP;
            float total = 0;
            for (int i=0; i<data.Length; i++)
            {
                for (int j=0; j<i; j++)
                {
                    if (data[i].arriv < data[j].arriv)
                    {
                        WT = data[j].arriv;
                        data[j].arriv = data[i].arriv;
                        data[i].arriv = WT;
                        NP = data[j].name;
                        data[j].name = data[i].name;
                        data[i].name = NP;
                        LE = data[j].dur;
                        data[j].dur = data[i].dur;
                        data[i].dur = LE;
                    }
                }
            }
            for (int r=0; r<data.Length; r++)
            {
                if (r > 0)
                {
                    if (data[r].arriv <= data[r - 1].done)
                    {
                        data[r].start = data[r - 1].done;
                    }
                    else
                    {
                        data[r].start = data[r].arriv;
                    }
                }
                else
                    data[r].start = data[r].arriv;

                data[r].done = data[r].dur + data[r].start;
                data[r].wait = data[r].start - data[r].arriv;
                data[r].TA = data[r].done - data[r].arriv;
                total += data[r].TA;
            }
            txttotal.Text = total.ToString();
            txtrata.Text = (total / data.Length).ToString();
            for (int r = 0; r < data.Length; r++)
            {
                LV.Items.Add(data[r].name);
                LV.Items[r].SubItems.Add(data[r].arriv.ToString());
                LV.Items[r].SubItems.Add(data[r].dur.ToString());
                LV.Items[r].SubItems.Add(data[r].start.ToString());
                LV.Items[r].SubItems.Add(data[r].done.ToString());
                LV.Items[r].SubItems.Add(data[r].wait.ToString());
                LV.Items[r].SubItems.Add(data[r].TA.ToString());
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtrata.Clear();
            txttotal.Clear();
            listview();
        }
    }
}
