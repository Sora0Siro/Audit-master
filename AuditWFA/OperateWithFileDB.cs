using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuditWFA
{
    public class OperateWithFileDB
    {
        //fields
        private string path = "C:\\Users\\aNs\\Desktop\\dataBase.txt";
        private string text;
        private string textFromFile;
        private List<string> lines;

        //constructors
        public OperateWithFileDB()
        {
            createFileIfNotExist();
        }


        //methods
        public void ReadFromFile()
        {
            try
            {
                StreamReader sr = new StreamReader(path);

                textFromFile = "";
                while ((textFromFile = sr.ReadLine()) != null)
                {
                    MessageBox.Show(textFromFile);
                }
                sr.Close();
            }

            catch (IOException e)
            {
                MessageBox.Show(e.Message + "Error in reading");
            }
        }

        public void WriteToFile()
        {
            try
            {
                StreamWriter sw = new StreamWriter(path);

                sw.WriteLine("Check state");
                sw.WriteLine("Check state");

                sw.Close();
            }
            catch (IOException e)
            {
                MessageBox.Show("Error in writing");
            }
        }

        public void WriteToFile(string text)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path);

                sw.WriteLine(text);
                sw.WriteLine(text);

                sw.Close();
            }
            catch (IOException e)
            {
                MessageBox.Show("Error in writing");
            }
        }

        public void createFileIfNotExist()
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }
        

    }
}
