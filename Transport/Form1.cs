using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void bereken()
        {
            decimal VP = VolumeBar.Value * (0.80m + (Convert.ToDecimal(VloeibaarBox.Checked) * 0.45m));
            decimal GP = GewichtBar.Value * (0.55m - (Convert.ToDecimal(VloeibaarBox.Checked) * 0.10m));

            decimal BIN = (VP + GP) * AfstandInBar.Value;
            decimal BUI = (VP + GP) * AfstandUitBar.Value * 1.45m;

            decimal DOU = (BUI > 0) ? Math.Max(WaardenBar.Value * 0.035m,45.0m) : 0.00m;

            label6.Text = "€" + Math.Round(DOU + BIN + BUI, 2);

            //Extra
            label13.Text = "€" + Math.Round(BIN,2);
            label14.Text = "€" + Math.Round(BUI,2);
            label15.Text = "€" + Math.Round(DOU, 2) + "  (" + Math.Round(WaardenBar.Value * 0.035m,2) + ")";
            label16.Text = "€" + Math.Round(VP,2);
            label17.Text = "€" + Math.Round(GP,2);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e){bereken();}
        private void numericUpDown2_ValueChanged(object sender, EventArgs e){bereken();}
        private void numericUpDown3_ValueChanged(object sender, EventArgs e){bereken();}
        private void numericUpDown4_ValueChanged(object sender, EventArgs e){bereken();}
        private void checkBox1_CheckedChanged(object sender, EventArgs e)   {bereken();}
        private void WaardenBar_ValueChanged(object sender, EventArgs e)    {bereken();}
        private void timer1_Tick(object sender, EventArgs e)                {bereken();}

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Size = new Size(450, 588);
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Size = new Size(450, 350);
            button1.Visible = true;
        }
    }
}
