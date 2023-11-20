using GroupDocs.Parser;
using GroupDocs.Parser.Data;
using GroupDocs.Parser.Options;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Xml;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;


namespace MubaNet2
{
    public partial class Form1 : Form
    {
        string bookText;
        string filename;
        int minimal = 0;
        string picname = "C:/book/image/pictures";
        string gabka = "C:/book/image/gabka";
        string picnamernd;
        int g = 1;
        int ind = 0;
        Random rnd = new Random();

        private Dictionary<char, int> word = new Dictionary<char, int>();
        private Dictionary<String, int> dictionary = new Dictionary<String, int>();

        private Dictionary<char, string> codes = new Dictionary<char, string>();

        public Form1()
        {
            InitializeComponent();
            entsim.Text = string.Empty;
            textentl.Text = string.Empty;
            pixelent.Text = string.Empty;
            pictent.Text = string.Empty;
            gaba.Checked = true; 
            ind = rnd.Next(4);
            picnamernd = gabka + ind + ".jpg";
            pictureBox1.Image = System.Drawing.Image.FromFile(picnamernd);
        }

        private void get_image(string filename)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load(filename);

            XmlNodeList pictureNodes = doc.GetElementsByTagName("binary");
            minimal = 0;

            foreach (XmlNode pictureNode in pictureNodes)
            {
                string base64ImageData = pictureNode.InnerText;
                byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                string pictureName = $"pictures{minimal}.png";
                File.WriteAllBytes("C:/book/image/" + pictureName, imageBytes);
                minimal++;
            }
        }


        private void get_text(string filename)
        {
            try
            {
                XDocument doc = XDocument.Load(filename);
                XNamespace ns = "http://www.gribuser.ru/xml/fictionbook/2.0"; 

                var body = doc.Root.Element(ns + "body"); 

                if (body != null)
                {
                    bookText = body.Value; 
                    richTextBox1.Text = bookText;
                }
                else
                {
                    richTextBox1.Text = "Формат FB2 не содержит элемента <body>.";
                }
            }
            catch (Exception ex)
            {
                richTextBox1.Text = $"Ошибка при загрузке или обработке файла: {ex.Message}";
            }
        }

        private void filebutton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = System.Drawing.Image.FromFile("C:/book/imagegabka/gabka3.jpg");
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "fb2 files (*.fb2)|*.fb2";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = openFileDialog.FileName;
                get_text(filename);
                get_image(filename);
                gaba.Checked = false;
                bookbutton.Checked = true;
                ind = 0;
                g = 0;
                picnamernd = picname + ind + ".png";
                pictureBox1.Image = System.Drawing.Image.FromFile(picnamernd);
            }
        }

        private void L_Click(object sender, EventArgs e)
        {
            if (g == 0)
            {
                if (ind - 1 >= 0)
                {
                    ind--;
                    picnamernd = picname + ind + ".png";
                    pictureBox1.Image = System.Drawing.Image.FromFile(picnamernd);
                }
                else
                {
                    ind = minimal - 1;
                    picnamernd = picname + ind + ".png";
                    pictureBox1.Image = System.Drawing.Image.FromFile(picnamernd);
                }
            }
            else
            {
                if (ind - 1 >= 0)
                {
                    ind--;
                    picnamernd = gabka + ind + ".jpg";
                    pictureBox1.Image = System.Drawing.Image.FromFile(picnamernd);
                }
                else
                {
                    ind = 3;
                    picnamernd = gabka + ind + ".jpg";
                    pictureBox1.Image = System.Drawing.Image.FromFile(picnamernd);
                }
            }
        }

        private void R_Click(object sender, EventArgs e)
        {
            if (g == 0)
            {
                if (ind + 1 <= minimal - 1)
                {
                    ind++;
                    picnamernd = picname + ind + ".png";
                    pictureBox1.Image = System.Drawing.Image.FromFile(picnamernd);
                }
                else
                {
                    ind = 0;
                    picnamernd = picname + ind + ".png";
                    pictureBox1.Image = System.Drawing.Image.FromFile(picnamernd);
                }
            }
            else
            {
                if (ind + 1 <= 3)
                {
                    ind++;
                    picnamernd = gabka + ind + ".jpg";
                    pictureBox1.Image = System.Drawing.Image.FromFile(picnamernd);
                }
                else
                {
                    ind = 0;
                    picnamernd = gabka + ind + ".jpg";
                    pictureBox1.Image = System.Drawing.Image.FromFile(picnamernd);
                }
            }
        }

        private void textent_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bookText.Length; i++)
            {
                if (word.ContainsKey(bookText[i]))
                {
                    word[bookText[i]]++;
                }
                else
                {
                    word.Add(bookText[i], 1);
                }
            }


            double H = 0;
            foreach(var w in word)
            {
                H += (Convert.ToDouble(w.Value) / Convert.ToDouble(bookText.Length)) * Math.Log(1 / (Convert.ToDouble(w.Value) / Convert.ToDouble(bookText.Length)), 2);
            }
            entsim.Text = "Энтропия символа = "  + Math.Round(H, 3).ToString();
            textentl.Text = "Энтропия книги = " + Math.Round(H * bookText.Length, 3).ToString();
        }

        private void picent_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(picnamernd);
            double[] probs = new double[256];
            double[][] RGB = new double[3][];
            RGB[0] = new double[256];
            RGB[1] = new double[256];
            RGB[2] = new double[256];
            double intensity = 0;
            Dictionary<double, double> pixel = new Dictionary<double, double>();
            for (int i = 0; i <  bmp.Width; i++)
            {
                for(int j = 0; j < bmp.Height; j++)
                {
                    Color c = bmp.GetPixel(i, j);
                    intensity = c.R * 0.299 + c.G * 0.587 + c.B * 0.114;
                    probs[Convert.ToInt32(intensity)] += 1;
                    RGB[0][c.R] += 1;
                    RGB[1][c.G] += 1;
                    RGB[2][c.B] += 1;
                    if (pixel.ContainsKey(intensity))
                    {
                        pixel[intensity]++;
                    }
                    else
                    {
                        pixel.Add(intensity, 1);
                    }
                }
            }

            double H = 0;
            foreach (var p in pixel)
            {
                H += (p.Value / (bmp.Width* bmp.Height)) * Math.Log(1 / (p.Value / (bmp.Width * bmp.Height)), 2);
            }
            pixelent.Text = "Энтропия пиксиля = " + Math.Round(H, 3).ToString();
            pictent.Text = "Энтропия картинки = " + Math.Round(H * bmp.Width * bmp.Height, 3).ToString();
            Form2 form2 = new Form2(probs, RGB, bmp.Width, bmp.Height);
            form2.Show();

        }

        private void entsim_Click(object sender, EventArgs e)
        {

        }

        private void pixelent_Click(object sender, EventArgs e)
        {

        }

        private void chart_Click(object sender, EventArgs e)
        {

        }

        private void gaba_Click(object sender, EventArgs e)
        {
            
        }

        private void gaba_CheckedChanged(object sender, EventArgs e)
        {
            if (g == 0)
            {
                bookbutton.Checked = false;
                gaba.Checked = true;
            }
            g = 1;
            ind = rnd.Next(4);
            picnamernd = gabka + ind + ".jpg";
            pictureBox1.Image = System.Drawing.Image.FromFile(picnamernd);

        }

        private void bookbutton_CheckedChanged(object sender, EventArgs e)
        {
            if (g == 1)
            {
                gaba.Checked = false;
                bookbutton.Checked = true;
            }
            g = 0;
            ind = 0;
            picnamernd = picname + ind + ".png";
            pictureBox1.Image = System.Drawing.Image.FromFile(picnamernd);
        }

        private List<int> Compress()
        {
            string text = richTextBox1.Text;
            int size = word.Count;

            int i = 0;
            foreach (char c in word.Keys)
                dictionary[c.ToString()] = i++;

            String found = "";
            List<int> result = new List<int>();
            foreach (char ch in text)
            {
                String charsToAdd = found + ch;
                if (dictionary.ContainsKey(charsToAdd.ToString()))
                    found = charsToAdd;
                else
                {
                    result.Add(dictionary[found]);
                    dictionary[charsToAdd] = size++;
                    found = ch.ToString();
                }
            }
            if (String.IsNullOrEmpty(found))
                result.Add(dictionary[found]);

            return result;

        }

        private void compress_button_Click(object sender, EventArgs e)
        {
            List<int> code = Compress();
            StringBuilder compressed = new StringBuilder();
            foreach (var character in code)
                compressed.Append(String.Format($"{character} "));
            Node Tree = BuildHuffmanTree(compressed.ToString());
            GetCodes(Tree);
            string texthaf = Encode(compressed.ToString(), codes);
            Form4 x = new Form4(compressed.ToString(), richTextBox1.Text.Length, code.Count, dictionary.Count(), texthaf, dictionary, codes);
            x.Show();
        }

        class Node
        {
            public char symbol;
            public int frequency;
            public Node left;
            public Node right;
        }


        private Node BuildHuffmanTree(string message)
        {
            Dictionary<char, int> frequencies = new Dictionary<char, int>();

            foreach (char symbol in message)
            {
                if (frequencies.ContainsKey(symbol))
                    frequencies[symbol]++;
                else
                    frequencies[symbol] = 1;
            }

            List<Node> nodes = new List<Node>();

            foreach (KeyValuePair<char, int> pair in frequencies)
            {
                Node node = new Node();
                node.symbol = pair.Key;
                node.frequency = pair.Value;
                nodes.Add(node);
            }

            while (nodes.Count > 1)
            {
                nodes.Sort((n1, n2) => n1.frequency - n2.frequency);

                Node left = nodes[0];
                Node right = nodes[1];

                Node parent = new Node();
                parent.frequency = left.frequency + right.frequency;
                parent.left = left;
                parent.right = right;

                nodes.RemoveRange(0, 2);
                nodes.Add(parent);
            }

            return nodes[0];
        }

        private void GetCodes(Node root)
        {
            TraverseTree(root, string.Empty, codes);
        }

        private void TraverseTree(Node node, string code, Dictionary<char, string> codes)
        {
            if (node.left == null && node.right == null)
            {
                codes[node.symbol] = code;
                return;
            }

            TraverseTree(node.left, code + "0", codes);
            TraverseTree(node.right, code + "1", codes);
        }

        private string Encode(string data, Dictionary<char, string> codes)
        {
            // Initialize the output string.
            var output = new StringBuilder();

            // Iterate through the string.
            foreach (var character in data)
            {
                // Append the code for the character.
                output.Append(codes[character] + " ");
            }

            // Return the encoded string.
            return output.ToString();
        }



    }

 

}
