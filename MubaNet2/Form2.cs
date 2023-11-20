using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MubaNet2
{
    public partial class Form2 : Form
    {
        public Form2(double[] probs, double[][] RGB, int w, int h)
        {
            InitializeComponent();
            chart(probs, RGB, w, h);
        }

        private void chart(double[] probs, double[][] RGB, int w, int h)
        {
            for (int i = 0; i < probs.Length; i++)
            {
                probs[i] /= (w * h);
                RGB[0][i] /= (w * h);
                RGB[1][i] /= (w * h);
                RGB[2][i] /= (w * h);
            }

            chart1.Series[0].Points.DataBindY(RGB[0]);
            chart1.Series[0].Color = Color.FromArgb(64, Color.Red);
            chart1.Series[1].Points.DataBindY(RGB[1]);
            chart1.Series[1].Color = Color.FromArgb(64, Color.Green);
            chart1.Series[2].Points.DataBindY(RGB[2]);
            chart1.Series[2].Color = Color.FromArgb(64, Color.Blue);
            chart1.Series[3].Points.DataBindY(probs);
            chart1.Series[3].Color = Color.Black;
            chart1.ChartAreas["ChartArea1"].AxisX.MinorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisY.MinorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
        }
    }
}
