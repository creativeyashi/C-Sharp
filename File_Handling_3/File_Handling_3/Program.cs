using System;
using System.IO;

namespace File_Handling_3
{
    class Program
    {
        class FileRead
        {
            public void ReadData()
            { 

                //This will Open your file named yg which you create in File_Handling_2 project
                FileStream fs = new FileStream("E:\\yg.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine("Program to show content of test file :");
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                string str = sr.ReadLine();
                while (str != null)
                {
                    Console.WriteLine(str);
                    str = sr.ReadLine();
                }
                Console.ReadLine();
                sr.Close();
                fs.Close();
            }
        }
        static void Main(string[] args)
        {
            FileRead wr = new FileRead();
            wr.ReadData();
        }
    }
}
