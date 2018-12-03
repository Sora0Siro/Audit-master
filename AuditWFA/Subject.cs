using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditWFA
{
    class Subject
    {
        //fields
        private string name; // what subject
        private Auditory auditory; //where would it be
        private Group group; // which group of students

        //constructors
        public Subject()
        {
            this.name = "";
            auditory = new Auditory();
        }
        public Subject(string name,Auditory auditory)
        {
            this.name = name;
            this.auditory = auditory;
        }

        public Subject(string name, Auditory auditory,Group group)
        {
            this.name = name;
            this.auditory = auditory;
            this.group = group;
        }

        //getters/setters
        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public Auditory getAuditory()
        {
            return this.auditory;
        }
        public void setAuditory(Auditory auditory)
        {
            this.auditory = auditory;
        }

        //methods
        public override string ToString()
        {
            return this.name + ", ";
        }

    }
}