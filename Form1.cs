using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fname = openFileDialog1.FileName;
                XmlDocument d = new XmlDocument();
                d.Load(fname);
                string text = d.GetElementsByTagName("text")[0].InnerText;
                this.textBox1.Text = text;

                string title = d.GetElementsByTagName("title")[0].InnerText;
                this.Text = text;

                string bcolor = d.GetElementsByTagName("background-color")[0].InnerText;
                this.BackColor = Color.FromName(bcolor);

                string fcolor = d.GetElementsByTagName("foreground-color")[0].InnerText;
                this.label1.ForeColor = Color.FromName(fcolor);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.BackColor = this.colorDialog1.Color;
            this.button1.ForeColor = this.colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.label1.ForeColor= this.colorDialog1.Color;
            this.button2.ForeColor = this.colorDialog1.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Text = textBox2.Text;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XmlDocument d = new XmlDocument();

                XmlText text = d.CreateTextNode(this.textBox1.Text);
                XmlText title = d.CreateTextNode(this.Text);
                XmlText fg = d.CreateTextNode(this.BackColor.ToArgb().ToString());
                XmlText bg = d.CreateTextNode(this.ForeColor.ToArgb().ToString());


                XmlElement conf = d.CreateElement(string.Empty, "configuration", string.Empty);
                d.AppendChild(conf);
                
                XmlElement el = d.CreateElement(string.Empty, "text", string.Empty);
                el.AppendChild(text);
                conf.AppendChild(el);

                el = d.CreateElement(string.Empty, "title", string.Empty);
                el.AppendChild(title);
                conf.AppendChild(el);

                el = d.CreateElement(string.Empty, "background-color", string.Empty);
                el.AppendChild(bg);
                conf.AppendChild(el);

                el = d.CreateElement(string.Empty, "foreground-color", string.Empty);
                el.AppendChild(fg);
                conf.AppendChild(el);

                d.Save(saveFileDialog1.FileName);
            }

        }
    }
}
