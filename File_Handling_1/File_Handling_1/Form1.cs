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
namespace File_Handling_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

             //for executing all the below steps you need to uncomment them one by one cz all steps can't execute at the same time

            //1.Create a file
             File.Create(@"E:\sample.txt");

            //add comment to the 1st step and uncomment the 2nd step

            //2.create copy of sample.txt file
            // File.Copy(@"E:\sample.txt", @"E:\copyofsample.txt");

            //3.Rename the file sample.txt
            //File.Move(@"E:\sample.txt", @"E:\renamesample.txt"); 

            //4.Delete the file
            //File.Delete(@"E:\renamesample.txt");




            //create an object of file so for this you don't need to pass location of this file in performing any operation

            //1
            //FileInfo file = new FileInfo(@"E:\sample.txt");  //hide comment on this line permanently so that you can perform  actions below
            // file.Create();

            //2
            //Create a copy of sample.txt file and here you need not to provide source file address
            //file.CopyTo(@"E:\copy.txt");

            //3
            //for renaming
            //file.MoveTo(@"E:\renameofsample.txt");

            //4
            //for deletion
            //file.Delete();
        }
    }
}
