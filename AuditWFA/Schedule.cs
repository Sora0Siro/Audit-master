using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditWFA
{
    //fields
    class Schedule
    {
        //dayName,Teacher info, Subjects for Teacher
        //Понедельник, Скрипник Ирина Анатольевна, <ДС,КДМ...>
        private List<Teacher> teachers;
        private List<Subject> subjects;

        public Schedule()
        {
            //есть список для предметов
            subjects = new List<Subject>();
            //есть список для учета преподавателей
            teachers = new List<Teacher>();


            //добавляем несколько предметов в список
            subjects.Add(new Subject("English", new Auditory()));
            subjects.Add(new Subject("English", new Auditory()));
            subjects.Add(new Subject("English", new Auditory()));

            //закрепляем список уроков за преподавателем
            Teacher t1 = new Teacher("Irina", "Skripnik", "Anatolievna", subjects);
            teachers.Add(t1);
            subjects = new List<Subject>();

            subjects.Add(new Subject("English", new Auditory(),new Group(15,"SP-16-2")));
            subjects.Add(new Subject("", new Auditory()));
            subjects.Add(new Subject("English", new Auditory(),new Group("SP-17-3")));

            //закрепляем список уроков за преподавателем
            Teacher t2 = new Teacher("Valeriy", "Boldirev", "Nikolayivech", subjects);
            teachers.Add(t2);
        }

        //methods

    }
}