using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{

    //Month ID Number - e.g. 1
    //MONTH 1 - Maximum Temperature
    //MONTH 1 - Minimum Temperature
    //MONTH 1 - Number of Days of Air Frost
    //MONTH 1 - Millimetres of rainfall that month
    //MONTH 1 - Hours of sunshine that month


    class Month
    {
        //class variables
        private int IDNum;
        private float maxTemp;
        private float minTemp;
        public int daysOfAirFrost;
        public int mmRain;
        public float hrsSunshine;


        //constructors
        public Month(int inputID, float inputMax, float inputMin,
                    int inputDaysFrost, int inputMmRain, float inputHrSunshine)
        {
            IDNum = inputID;
            maxTemp = inputMax;
            minTemp = inputMin;
            daysOfAirFrost = inputDaysFrost;
            mmRain = inputMmRain;
            hrsSunshine = inputHrSunshine;
        }

        public Month(int inputID)
        {
            IDNum = inputID;
            maxTemp = 0f;
            minTemp = 0f;
            daysOfAirFrost = 0;
            mmRain = 0;
            hrsSunshine = 0f;
        }

        //all the getters

        public int getId()
        {
            return IDNum;
        }
        public float getMaxTemp()
        {
            return maxTemp;
        }
        public float getMinTemp()
        {
            return minTemp;
        }
        public int getDaysFrost()
        {
            return daysOfAirFrost;
        }
        public int getMmRain()
        {
            return mmRain;
        }
        public float getHrSunshine()
        {
            return hrsSunshine;
        }


        //all the setters
        

        public void setItAll(int inputID, float inputMax, float inputMin,
                            int inputDaysFrost, int inputRain, float inputSunshine)
        {
            IDNum = inputID;
            maxTemp = inputMax;
            minTemp = inputMin;
            daysOfAirFrost = inputDaysFrost;
            mmRain = inputRain;
            hrsSunshine = inputSunshine;
        }

        public void setID(int inputId)
        {
            IDNum = inputId;
        }
        public void setMax(float inputMax)
        {
            maxTemp = inputMax;
        }
        public void setMin(float inputMin)
        {
            minTemp = inputMin;
        }
        public void setDaysFrost(int inputDaysFrost)
        {
            daysOfAirFrost = inputDaysFrost;
        }
        public void setRain(int inputRain)
        {
            mmRain = inputRain;
        }
        public void setHrSunshine(float inputSunhine)
        {
            hrsSunshine = inputSunhine;
        }
    }
}
