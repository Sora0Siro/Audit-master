using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditWFA
{
    class Day
    {
        //fields
        private DateTime date;
        private Schedule schedule;

        public Day()
        {
            date = new DateTime();
            schedule = new Schedule();
        }

        public Day(DateTime day,Schedule schedule)
        {
            this.date = day;
            this.schedule = schedule;
        }

        //methods
        public DateTime getDate()
        {
            return this.date;
        }

        public void setDate(DateTime date)
        {
            this.date = date;
        }

        public Schedule getSchedule()
        {
            return this.schedule;
        }

        public void setSchedule(Schedule schedule)
        {
            this.schedule = schedule;
        }
    }
}