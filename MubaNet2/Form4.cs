using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MubaNet2
{
    public partial class Form4 : Form
    {
        string texthaf;
        Dictionary<String, int> dictionary;
        Dictionary<char, string> codes;

        public Form4(string cod, int lentext, string texthaf1, Dictionary<String, int> dictionary1, Dictionary<char, string> codes1, List<int> code)
        {
            InitializeComponent();
            compText.Text = cod;
            Lentext.Text = "Длинна изначального текста = " + lentext.ToString();
            Lencode.Text = "Длинна сжатого текста = " + code.Count.ToString();
            Lendict.Text = "Длинна словаря = " + dictionary1.Count.ToString();
            label1.Text = "Избыточность кода = " + (lentext - code.Count - dictionary1.Count).ToString();

            hafmrext.Text = texthaf1.ToString();
            foreach (var smb in codes1)
            {
                richTextBox1.Text += ($"{smb.Key} = {smb.Value}" + " " + "\n");
            }
            texthaf = texthaf1;
            /*            label4.Text = "Длинна сжатого текста = " + texthaf1.Length.ToString();
                        label3.Text = "Длинна словаря = " + codes1.Count.ToString();*/
            string t = texthaf1.Replace(" ", "");
            label2.Text = "Избыточность кода = " + (lentext - (t.Length / 8)).ToString();

            dictionary = dictionary1;
            codes = codes1;
        }

        private void decipherButton_Click(object sender, EventArgs e)
        {
            List<int> code = decipher_step_one();
            StringBuilder compressed = new StringBuilder();
            foreach (var character in code)
                compressed.Append(String.Format($"{character} "));
            half_unfoldedtext.Text = compressed.ToString();
            finaltext.Text = decipher_step_two(code);
        }

        private List<int> decipher_step_one()
        {
            StringBuilder number = new StringBuilder();
            string[] code = texthaf.Split(' ');
            List<int> half_unfolded = new List<int>();
            string spase = codes[' '];
            for (int i = 0; i < code.Length; i++)
            {
                if (code[i].ToString() != spase)
                {
                    number.Append(Getkey1(code[i].ToString(), codes));
                }
                else
                {
                    half_unfolded.Add(Convert.ToInt32(number.ToString()));
                    number = new StringBuilder();
                }
            }
            return half_unfolded;
        }

        private char Getkey1(string value, Dictionary<char, string> codes)
        {
            foreach (var code in codes)
            {
                if (code.Value == value)
                {
                    return code.Key;
                }
            }
            return ' ';
        }

        private string decipher_step_two(List<int> code)
        {
            StringBuilder text = new StringBuilder();
            foreach (var ch in code)
            {
                text.Append(Getkey2(ch, dictionary));
            }
            return text.ToString();
        }

        private string Getkey2(int value, Dictionary<String, int> dic)
        {
            foreach (var code in dic)
            {
                if (code.Value == value)
                {
                    return code.Key;
                }
            }
            return " ";
        }


    }
}
