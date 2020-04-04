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
namespace File_Handling_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(@"E:\WriteFile.txt");
            StreamWriter writer = file.CreateText();
            writer.WriteLine(textBox1.Text);
            writer.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(@"E:\WriteFile.txt");
            if(file.Exists)
            {
                StreamReader reader = file.OpenText();
                string str = "";
                while((str=reader.ReadLine()) != null)
                {
                    textBox1.Text += str;
                }
                reader.Close();
            }
        }
    }
}
