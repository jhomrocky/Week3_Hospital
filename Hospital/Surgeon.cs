using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Surgeon : Doctor
    {
        private bool currentlyOperating;

        public bool CurrentlyOperating
        {
            get { return this.currentlyOperating; }
            set { this.currentlyOperating = value; }
        }
        public Surgeon(string employeeName, int employeeNumber, string specialtyArea, bool currentlyOperating)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
            this.currentlyOperating = currentlyOperating;
        }
    }
}
