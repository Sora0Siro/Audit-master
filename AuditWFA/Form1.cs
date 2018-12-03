using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AuditWFA
{
    public partial class Form1 : Form
    {
        //fields
        private Dictionary<string, List<List<string>>> dc;
        private List<string> localList;
        private bool permissAdd = true;
        private bool scheduleTypeCalendar = false;
        private string FacultiesDirectory;
        private string AuditoriesPath;
        private string FullDirectory;
        private string dayScheduleInfo_Path;
        private string scheduleFileName; //день недели + тип недели
        private List<Teacher> teachers;
        private Dictionary<string, List<string>> coursesDC;
        private Dictionary<string, Dictionary<string, List<string>>> cathDC;
        private Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>> facultDC;
        private Dictionary<string, List<string>> auditoriesDC;
        private string[] numbers = { "1", "2", "3", "4", "5", "6", "7" };

        //construct
        public Form1()
        {
            InitializeComponent();
            hideCalendarType();

            FullDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\DataBase";
            AuditoriesPath = FullDirectory + "\\Auditories.txt";
            FacultiesDirectory = FullDirectory + "\\Faculties";

            dc = new Dictionary<string, List<List<string>>>();
            coursesDC = new Dictionary<string, List<string>>();
            cathDC = new Dictionary<string, Dictionary<string, List<string>>>();
            facultDC = new Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>>();
            auditoriesDC = new Dictionary<string, List<string>>();

            setAuditoriesFromFile();

            Courses c = new Courses();
            c.ReadAllCourses(coursesDC, cathDC, facultDC, FacultiesDirectory);
            setFacultiesNew();
        }

        public void all()
        {
            foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, List<string>>>> facult in facultDC)
            {
                foreach (KeyValuePair<string, Dictionary<string, List<string>>> cathedr in facult.Value)
                {
                    foreach (KeyValuePair<string, List<string>> course in cathedr.Value)
                    {

                    }
                }
            }
        }

        //methods
        private void button1_Click(object sender, EventArgs e)
        {
            if (textField_Teacher.SelectedIndex > -1 && textField_Subject.SelectedIndex > -1 && textField_Group.SelectedIndex > -1 && textField_Aud.SelectedIndex > -1 && textField_Number.SelectedIndex > -1)
            {
                if(Permission())
                {
                    //MessageBox.Show("ACCESS GRANTED");

                    localList = new List<string>();

                    localList.Add(textField_Subject.Text);
                    localList.Add(textField_Group.Text);
                    localList.Add(textField_Aud.Text);
                    localList.Add(textField_Number.Text);

                    if(dc.ContainsKey(textField_Teacher.Text))
                    {
                        dc[textField_Teacher.Text].Add(localList);
                    }
                    else
                    {
                        List<List<string>> n = new List<List<string>>();
                        n.Add(localList);

                        dc.Add(textField_Teacher.Text,n);
                    }

                    this.Table.Rows.Add(textField_Teacher.Text, textField_Subject.Text, textField_Group.Text, textField_Aud.Text, textField_Number.Text);
                    saveSchedule();
                }
                else
                {
                    //MessageBox.Show("ACCESS DENIED");
                }
            }
            else
            {
                MessageBox.Show("Некоторые поля незаполнены");
            }
            permissAdd = true;
        }

        private bool Permission()
        {
            if(dc != null && dc.Count > 0 && dc.ContainsKey(textField_Teacher.Text))
            {
                foreach(List<string> list in dc[textField_Teacher.Text])
                {
                    if (textField_Number.Text == list[3])
                    {
                        permissAdd = false;
                        MessageBox.Show("На выбранной паре уже есть занятие");
                        return permissAdd;
                    }
                }
            }
            else if(dc == null)
            {
                dc = new Dictionary<string, List<List<string>>>();
                return permissAdd;
            }
            else
            {
                for (int i = 0; i < Table.RowCount - 1; i++)
                {
                    if (textField_Number.Text == Table.Rows[i].Cells[4].Value.ToString())
                    {
                        if (textField_Aud.Text == Table.Rows[i].Cells[3].Value.ToString())
                        {
                            MessageBox.Show("Выбранная вами аудитория уже занята");
                            permissAdd = false;
                            return permissAdd;
                        }
                        else
                        {
                        }
                    }
                }
            }

            return permissAdd;
        }

        //sets
        public void setTeacherInfo(string path)
        {
            textField_Teacher.Items.Clear();
            teachers = new List<Teacher>();
            foreach (string file in Directory.EnumerateFiles(path, "*.txt"))
            {
                string teacherName = Path.GetFileNameWithoutExtension(file);
                string[] subjects = File.ReadAllLines(file, Encoding.Unicode);
                
                teachers.Add(new Teacher(teacherName,new List<string>(subjects)));
            }

            foreach(Teacher teacher in teachers)
            {
                if (textField_Teacher.Items.IndexOf(teacher.getSurname()) > -1)
                {

                }
                else
                {
                    textField_Teacher.Items.Add(teacher.getSurname());
                }
            }
        }

        public void setFacultiesNew()
        {
            dropList_Faculty.Items.Clear();
            foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, List<string>>>> facult in facultDC)
            {
                dropList_Faculty.Items.Add(facult.Key);
            }
        }

        public void setDropList_Course()
        {
            dropList_Course.Items.Clear();

            foreach (KeyValuePair<string, List<string>> cathedr in facultDC[dropList_Faculty.Text][dropList_Cath.Text])
            {
                dropList_Course.Items.Add(cathedr.Key);
            }

        }

        public void setCathedras()
        {
            dropList_Cath.Items.Clear();
            foreach (KeyValuePair<string, Dictionary<string, List<string>>> cathedr in facultDC[dropList_Faculty.Text])
            {
                dropList_Cath.Items.Add(cathedr.Key);
            }
        }

        public void setAuditoriesFromFile()
        {
            try
            {
                string[] auditories = File.ReadAllLines(AuditoriesPath, Encoding.Unicode);
                string tmpKey = "";
                List<string> tmpList = new List<string>();

                for (int i = 0; i < auditories.Length; i++)
                {
                    if (auditories[i].Contains("ауд.") || auditories[i].Contains("лаб.") || auditories[i].Contains("ОЦ") || auditories[i].Contains("оц"))
                    {
                        tmpKey = auditories[i];
                    }
                    else if (auditories[i] == "" || auditories[i] == " ")
                    {
                        auditoriesDC.Add(tmpKey, tmpList);
                        tmpKey = "";
                        tmpList = new List<string>();
                    }
                    else
                    {
                        tmpList.Add(auditories[i]);
                        if (i == auditories.Length - 1)
                        {
                            auditoriesDC.Add(tmpKey, tmpList);
                            tmpKey = "";
                            tmpList = new List<string>();
                        }
                    }
                }

                setDropListAuditories();
            }
            catch(FileNotFoundException e)
            {
                MessageBox.Show("Файл не был найден");
            }
        }

        private void setDropListAuditories()
        {
            textField_Aud.Items.Clear();
            foreach (KeyValuePair<string, List<string>> dc in auditoriesDC)
            {
                textField_Aud.Items.Add(dc.Key);
            }
        }

        private void setDropListNumber()
        {
            textField_Number.Items.Clear();
            foreach(string s in numbers)
            {
                textField_Number.Items.Add(s);
            }
        }

        private void addToDC(string key, List<string> list)
        {
            List<string> tmp = list.ToList<string>();
            tmp.RemoveAt(0);

            if (dc.ContainsKey(key))
            {
                dc[key].Add(tmp);
            }
            else
            {
                List<List<string>> n = new List<List<string>>();
                n.Add(tmp);

                dc.Add(key, n);
            }
            tmp = new List<string>();
        }

        //events
        private void textField_Teacher_TextChanged(object sender, EventArgs e)
        {
            textField_Subject.Text = "";
            string SelectedTeacher = textField_Teacher.Text;

            foreach (Teacher teacher in teachers)
            {
                if (teacher.getSurname() == SelectedTeacher)
                {
                    textField_Subject.Items.Clear();

                    foreach(string s in teacher.getSubs())
                    {
                        textField_Subject.Items.Add(s);
                    }
                    break;
                }
            }
        }

        private void dropList_Course_TextChanged(object sender, EventArgs e)
        {
            textField_Group.Items.Clear();

            foreach (string s in facultDC[dropList_Faculty.Text][dropList_Cath.Text][dropList_Course.Text])
            {
                textField_Group.Items.Add(s);
            }
            textField_Group.Text = "";
        }

        private void dropList_Cath_TextChanged(object sender, EventArgs e)
        {
            clearFields();
            clearDropLists();
            //file = faculty dir + choosed cathedra
            //teachers from file
            //courses/groups from file

            string totalPath = "";
            totalPath = FacultiesDirectory + "\\" + dropList_Faculty.Text + "\\" + dropList_Cath.Text; //teacher folder, course .txt
            var directories = Directory.GetDirectories(totalPath);
            foreach(string s in directories)
            {
                if(s.Contains("Teach"))
                {
                    setTeacherInfo(s);
                    break;
                }
            }
            setDropList_Course();
            setDropListAuditories();
            setDropListNumber();
            //setCourses

            loadSchedule();
        }

        private void dropList_Faculty_TextChanged(object sender, EventArgs e)
        {
            //clearFields();
            clearDropLists();
            clearTable();
            setCathedras();
        }

        private void DataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DatabaseSearch.ShowDialog() == DialogResult.OK) FullDirectory = DatabaseSearch.SelectedPath;
            AuditoriesPath = FullDirectory + "\\Auditories.txt";
            FacultiesDirectory = FullDirectory + "\\Faculties";
        }

        private void AboutAuditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm inf = new InfoForm(auditoriesDC, AuditoriesPath);
            inf.FormClosed += Inf_FormClosed;
            inf.ShowDialog();
        }

        private void Inf_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            //setAuditoriesFromFile();
            setDropListAuditories();
        }

        private void dtp_Teach_ValueChanged(object sender, EventArgs e)
        {
            loadSchedule();
        }

        private void btt_DeleteSchLine_Click(object sender, EventArgs e)
        {
            if(Table.CurrentCell.Value != null && Table.CurrentCell.Value != " ")
            {
                Table.Rows.RemoveAt(Table.CurrentRow.Index);
                saveSchedule();
                loadSchedule();
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления пары.");
            }
        }

        private void календарьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actScheduleTypes();
            loadSchedule();
        }

        private void числЗнамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actScheduleTypes();
            loadSchedule();
        }

        private void chck_Ch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chck_Zn_CheckedChanged(object sender, EventArgs e)
        {
            loadSchedule();
        }

        private void dropList_Schedule_TextChanged(object sender, EventArgs e)
        {
            loadSchedule();
        }

        //clear
        public void clearFields()
        {
            textField_Teacher.Text = "";
            textField_Subject.Text = "";
            textField_Group.Text = "";
            textField_Aud.Text = "";
            textField_Number.Text = "";
        }

        public void clearDropLists()
        {
            dropList_Course.Items.Clear();
            textField_Teacher.Items.Clear();
            textField_Subject.Items.Clear();
            textField_Group.Items.Clear();
            textField_Aud.Items.Clear();
            textField_Number.Items.Clear();
        }

        public void clearCourseField()
        {
            dropList_Course.Text = "";
        }

        private void hideCalendarType()
        {
            gB_CalendarType.Visible = false;
            scheduleTypeCalendar = false;
            gB_ChZnType.Visible = true;
        }

        private void hideChZnType()
        {
            gB_ChZnType.Visible = false;
            scheduleTypeCalendar = true;
            gB_CalendarType.Visible = true;
        }

        private void clearTable()
        {
            Table.Rows.Clear();
            Table.Refresh();
        }

        //check
        private bool checkFieldsForScheduleTable()
        {
            bool state = true;
            if (dropList_Faculty.Text != "" && dropList_Faculty.Text != " " && dropList_Cath.Text != "" && dropList_Cath.Text != " ")
            {
                return state;
            }
            else
            {
                return !state;
            }
        }

        private string getWeekState()
        {
            string stateOfWeek = "";
            if (chck_Ch.Checked)
            {
                stateOfWeek = chck_Ch.Text;
            }
            else if (chck_Zn.Checked)
            {
                stateOfWeek = chck_Zn.Text;
            }
            return stateOfWeek;
        }

        //files
        private void saveSchedule()
        {
            writeScheduleInFile();
        }

        private void writeScheduleInFile()
        {
            List<string> tmp = new List<string>();

            for (int i = 0; i < Table.Rows.Count-1; i++)
            {
                for (int j = 0; j < Table.Columns.Count; j++)
                {
                    tmp.Add(Table.Rows[i].Cells[j].Value.ToString());
                }
                tmp.Add("");
            }
            string[] contents = tmp.Select(i => i.ToString()).ToArray();
            File.WriteAllLines(dayScheduleInfo_Path, contents, Encoding.Unicode);
            tmp.Clear();
        }

        private void loadSchedule()
        {
            bool gotFilePath = false;

            dc.Clear();
            if (checkFieldsForScheduleTable())
            {
                Table.Rows.Clear();
                Table.Refresh();
                
                if (scheduleTypeCalendar)
                {
                    dayScheduleInfo_Path = FacultiesDirectory + "\\" + dropList_Faculty.Text + "\\" + dropList_Cath.Text + "\\Schedule\\" + dtp_Teach.Text + ".txt";
                    gotFilePath = true;
                }
                else if (!scheduleTypeCalendar)
                {
                    if (dropList_Schedule.Text == " " || dropList_Schedule.Text == "")
                    {
                        gotFilePath = false;
                    }
                    else if (dropList_Schedule.Text != " " && dropList_Schedule.Text != "")
                    {
                        scheduleFileName = dropList_Schedule.Text + " " + getWeekState();
                        dayScheduleInfo_Path = FacultiesDirectory + "\\" + dropList_Faculty.Text + "\\" + dropList_Cath.Text + "\\Schedule\\" + scheduleFileName + ".txt";
                        gotFilePath = true;
                    }
                }
                
                if(gotFilePath)
                {
                    if (File.Exists(dayScheduleInfo_Path))
                    {
                        string[] conts = File.ReadAllLines(dayScheduleInfo_Path, Encoding.Unicode);
                        List<string> list = new List<string>();

                        //column < Table.ColumnCount
                        for (int i = 0; i < conts.Length; i++)
                        {
                            if (conts[i] != "")
                            {
                                list.Add(conts[i]);
                            }
                            else if (conts[i] == "" && list.Count > 0)
                            {
                                addToDC(list[0], list);
                                Table.Rows.Add(list[0], list[1], list[2], list[3], list[4]);
                                list.Clear();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Расписание на данный день отсутствует");
                        //File.Create(dayScheduleInfo_Path);
                    }
                }

            }
            else
            {
                if(dropList_Faculty.Text == " " || dropList_Faculty.Text == null)
                {
                    MessageBox.Show("Выберите факультет");
                }
                else if(dropList_Cath.Text == " " || dropList_Cath.Text == null)
                {
                    MessageBox.Show("Выберите кафедру");
                }
            }
        }

        private void actScheduleTypes()
        {
            if(gB_CalendarType.Visible)
            {
                hideCalendarType();
            }
            else if(gB_ChZnType.Visible)
            {
                hideChZnType();
            }
        }
    }
}

/*
 You can use ContainsKey:

if (dict.ContainsKey(key)) { ... }

or TryGetValue:

dict.TryGetValue(key, out value);

 */