using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Assignment
{
    internal class GPASC
    {
        private double max = 0;
        private string name = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="gpa"></param>
        /// <param name="name"></param>
        public void addGPA(double gpa, string name)
        {
            if (this.max < gpa)
            {
                this.max = gpa;
                this.name = name;
            }
        }
        public double getMax()
        {
            return this.max;
        }
        public string getMaxName()
        {
            return name;
        }
        public double reMax() { return max = 0; }
        public string reName() { return name = ""; }

    }
}
