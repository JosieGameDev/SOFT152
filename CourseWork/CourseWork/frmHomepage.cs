using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseWork
{
    public partial class frmHomepage : Form
    {
        public static frmHomepage frmKeepHomepage = null;

        //variables
        int yearIndex = 0;
        Year currentYear;
        Month[] currentMonthArray;


        public void stockOutput()
        {
            lstMonth.Items.Clear();
            lstYear.Items.Clear(); 
            
            //get the index
            //setSelectedIndex();

            //set the current things 
            currentYear = Data.YearArray[yearIndex];
            currentMonthArray = currentYear.getMonthArray();

           

            if (Data.YearArray != null)
            {
                foreach (Year y in Data.YearArray)
                {
                    Month[] MonthArray = y.getMonthArray();
                    if (y != null)
                    {
                        lstYear.Items.Add(y.getID() + " " + y.getDescription());
                    }
                }
                if (currentYear != null)
                {
                    
                    foreach (Month m in currentMonthArray)
                    {

                        if (m != null)
                        {


                            //private int IDNum;
                            //private float maxTemp;
                            //private float minTemp;
                            //public int daysOfAirFrost;
                            //public int mmRain;
                            //public float hrsSunshine;
                            lstMonth.Items.Add("Month ID: " + m.getId() + ". MaxTemp: " + m.getMaxTemp() + ". Min Temp: "
                                                + m.getMinTemp() + ". Days Of AirFrost: " + m.getDaysFrost()
                                                + ". Mm of Rainfall: " + m.getMmRain() + ". Hours of Sunshine: "
                                                + m.getHrSunshine() + ".");
                        }
                    }
                    
                }
            }
        }
    

        public frmHomepage()
        {
            InitializeComponent();
            frmKeepHomepage = this;
        }

        private void btnReadIn_Click(object sender, EventArgs e)
        {
            ReadInDataYear();
        }

        private void btnAddMonth_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddMonth tempAddMonth = new frmAddMonth();
            tempAddMonth.Show();
        }

        private void btnEditMonth_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEditMonth tempEditMonth = new frmEditMonth();
            tempEditMonth.Show();
        }

        private void btnAddYear_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddYear tempAddYear = new frmAddYear();
            tempAddYear.Show();
        }

        private void btnEditYear_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEditYear tempEditYear = new frmEditYear();
            tempEditYear.Show();
        }

        public void ReadInDataYear()
        {
            //year variables
            int inYearId;
            string inYearDescription;

            //create streamreader
            //StreamReader inputReader = new StreamReader("heathrowCORE input.txt");
            StreamReader inputReader = new StreamReader("testinput.txt");

            while (!inputReader.EndOfStream)
            {
                //get the Year Data
                inYearId = Convert.ToInt32(inputReader.ReadLine());
                inYearDescription = inputReader.ReadLine();

                //create a new instance of year using this data
                Year tempYear = new Year(inYearId, inYearDescription);

                //set up book array wihtin this library
                tempYear.setMonthArray(getNextMonthArray(inputReader, tempYear.getMonthArray(), 12));

                //resize array using sep method
                growYearArray(ref Data.YearArray);

                //add this new year to the year array
                Data.YearArray[Data.YearArray.Length - 1] = tempYear;
            }
            inputReader.Close();
        }



        private Month[] getNextMonthArray(StreamReader inputData, Month[] MonthArray, int numOfMonths)
        {
            
            //vars of the month class;
            int inputIDNum;
            double inputMaxTemp;
            double inputMinTemp;
            int inputDaysOfAirFrost;
            double inputMmRain;
            double inputHrsSunshine;
            //vars for the loop
            int mnth;
            int mnthArraySize;

            for (mnth = 0; mnth < numOfMonths; mnth++)
            {
                //set the variables based on the readline
                inputIDNum = Convert.ToInt32(inputData.ReadLine());
                inputMaxTemp = Convert.ToDouble(inputData.ReadLine());
                inputMinTemp = Convert.ToDouble(inputData.ReadLine());
                inputDaysOfAirFrost = Convert.ToInt32(inputData.ReadLine());
                inputMmRain = Convert.ToDouble(inputData.ReadLine());
                inputHrsSunshine = Convert.ToDouble(inputData.ReadLine());

                //create newinstance of month based on these
                Month tempMonth = new Month(inputIDNum, inputMaxTemp, inputMinTemp, inputDaysOfAirFrost,
                                            inputMmRain, inputHrsSunshine);

                //get ad resize the array
                if (MonthArray == null)
                {
                    mnthArraySize = 0;
                }
                else
                {
                    mnthArraySize = MonthArray.Length;
                }

                //resize it
                Array.Resize(ref MonthArray, mnthArraySize + 1);
                //add to this array
                MonthArray[mnthArraySize] = tempMonth;

            }

            return MonthArray;

        }

        void growYearArray(ref Year[] currentYearArray)
        {
            int yearSize;

            if (currentYearArray == null)
            {
                yearSize = 0;
            }
            else
            {
                yearSize = currentYearArray.Length;
            }

            //resize the array
            Array.Resize(ref currentYearArray, yearSize + 1);
        }

        

       
        public void setSelectedIndex()
        {
            
        }
        private void btnShowData_Click(object sender, EventArgs e)
        {
            stockOutput();
        }

        private void lstYear_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            yearIndex = (lstYear.SelectedIndex);
            stockOutput();
        }
    }
}
