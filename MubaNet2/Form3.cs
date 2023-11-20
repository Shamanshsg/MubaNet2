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
    public partial class Form3 : Form
    {
        public Form3(Dictionary<char, int> word)
        {
            InitializeComponent();
            chart(word);
        }

        private void chart(Dictionary<char, int> word)
        {
            var res = word.Values.ToArray();
            for (int i = 0; i < res.Length; i++)
                res[i] /= Text.Length;

            chart1.Series[0].Points.Clear();
            foreach (var item in word) {
                int t = Convert.ToInt32(item.Key);
                if ((t >= 'a' && t <= 'я')) {
                    chart1.Series[0].Points.AddXY(item.Key.ToString(), item.Value);
                }
            }
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.ChartAreas["ChartArea1"].AxisX.MinorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisY.MinorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
        }
    }
}
