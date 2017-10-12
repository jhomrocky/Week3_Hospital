using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    abstract class Patient_Care : Hospital_Employee
    {
        protected string department;

        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }


    }
}
