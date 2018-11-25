using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Year
    {

        //class variables
        private int yearID;
        private string yearDescription;
        private Month[] Months = new Month[12];

        //constructors
        public Year(int inputYearID, string inputDescription, Month[] monthList)
        {
            yearID = inputYearID;
            yearDescription = inputDescription;
            Months = monthList;
        }
        public Year(int inputYearID, string inputDescription)
        {
            yearID = inputYearID;
            yearDescription = inputDescription;
        }

        //all the getters
        public int getID()
        {
            return yearID;
        }
        public string getDescription()
        {
            return yearDescription;
        }
        public Month[] getMonthArray()
        {
            return Months;
        }

        //all the setters
        public void setID(int inputID)
        {
            yearID = inputID;
        }
        public void setDescription(string inputDescription)
        {
            yearDescription = inputDescription;
        }
        public void setMonthArray(Month[] inputMonths)
        {
            Months = inputMonths;
        }
        public void setItAll(int inputId, string inputDescription, Month[] inputMonths)
        {
            yearID = inputId;
            yearDescription = inputDescription;
            Months = inputMonths;
        }
    }
}
