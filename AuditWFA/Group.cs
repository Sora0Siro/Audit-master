using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditWFA
{
    class Group
    {
        //fields
        private string name; // name of group
        private int count; // how many students? for future dev

        //constructors
        public Group()
        {
            name = "";
            count = 0;
        }
        public Group(string name)
        {
            this.name = name;
        }
        public Group(int count, string name)
        {
            this.count = count;
            this.name = name;
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
        public int getCount()
        {
            return this.count;
        }
        public void setCount(int count)
        {
            this.count = count;
        }
    }
}
