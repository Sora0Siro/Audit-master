using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditWFA
{
    class Auditory
    {
        //fields
        private int number;
        private bool projector;//projector availability

        //Constructors
        public Auditory()
        {
            this.number = 0;
            this.projector = false;
        }
        public Auditory(int number,bool projector)
        {
            this.number = number;
            this.projector = projector;
        }

        //getters/setters
        public int getNumber()
        {
            return this.number;
        }
        public void setNumber(int number)
        {
            this.number = number;
        }
        public bool getProjectorAvail()
        {
            return this.projector;
        }
        public void setProjector(bool projector)
        {
            this.projector = projector;
        }
    }
}
