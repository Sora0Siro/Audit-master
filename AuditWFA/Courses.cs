using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AuditWFA
{
    public class Courses
    {
        //private string fileWithCourses = "C:\\Users\\aNs\\Documents\\Visual Studio 2015\\Projects\\Audit\\AuditWFA\\DataBase\\ФЕЕИТ\\ПЗАС";
        //private string FacultiesDirectory = "C:\\Users\\aNs\\Documents\\Visual Studio 2015\\Projects\\Audit\\AuditWFA\\DataBase";
        //private string FacultiesDirectory = "C:\\Users\\aNs\\Desktop\\Audit-master\\AuditWFA\\DataBase";
        List<string> courses;

        public Courses()
        {
            this.courses = new List<string>();
        }

        public Courses(List<string> courses)
        {
            this.courses = courses;
        }

        public List<string> getCourses()
        {
            return this.courses;
        }
        public void ReadAllCourses(Dictionary<string, List<string>> coursesDC,
        Dictionary<string, Dictionary<string, List<string>>> cathDC,
        Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>> facultDC,
        string FacultiesDirectory)
        {
            var faculties = Directory.GetDirectories(FacultiesDirectory);

            foreach(string faculty in faculties)
            {
                var cathedras = Directory.GetDirectories(faculty);

                foreach(string cathedra in cathedras)
                {
                    
                    string[] tm = File.ReadAllLines(cathedra + "\\courses.txt", Encoding.Unicode);
                    courseLogic(tm, coursesDC);
                    cathDC.Add(Path.GetFileName(cathedra), coursesDC);
                    coursesDC = new Dictionary<string, List<string>>();
                }
                facultDC.Add(Path.GetFileName(faculty), cathDC);
                cathDC = new Dictionary<string, Dictionary<string, List<string>>>();
            }
        }

        public void courseLogic(string[] courses, Dictionary<string,List<string>> courseDC)
        {
            List<string> names = new List<string>();
            string tmpKey = "";

            for (int i = 0; i < courses.Length; i++)
            {
                string s = courses[i];

                if (s.Contains("курс") || s.Contains("Курс") || s.Contains("Магистры"))
                {
                    tmpKey = s;
                }
                else if (s != " " && s != "")
                {
                    names.Add(s);
                }
                if (s == "" || s == " " || i == courses.Length - 1)
                {
                    courseDC.Add(tmpKey, names);
                    names = new List<string>();
                    tmpKey = "";
                }
            }
        }
    }
}