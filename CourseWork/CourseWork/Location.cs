using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Location
    {

        //variables
        string locationName;
        string StreetNumberAndName;
        string county;
        string postcode;
        float longitude;
        float latitude;
        int yearsInDataset;
        Year[] years;


        
        

        //constructor
        public Location(string inputLocation, string inputStreetDetails, string inputCounty,
                        string inputPostcode, float inputLong, float inputLat, int inputYears)
        {
            locationName = inputLocation;
            StreetNumberAndName = inputStreetDetails;
            county = inputCounty;
            postcode = inputPostcode;
            longitude = inputLong;
            latitude = inputLat;
            yearsInDataset = inputYears;

        }

        //all the getters
        public string getLocation()
        {
            return locationName;
        }
        public string getStreetDetails()
        {
            return StreetNumberAndName;
        }
        public string getCounty()
        {
            return county;
        }
        public string getPostcode()
        {
            return postcode;
        }
        public float getLongitude()
        {
            return longitude;
        }
        public float getLatitude()
        {
            return latitude;
        }
        public int getYears()
        {
            return yearsInDataset;
        }

        //all the setters
        //string inputLocation, string inputStreetDetails, string inputCounty,
        //string inputPostcode, float inputLong, float inputLat, int inputYears)

        public void setLocation(string inputLocation)
        {
            locationName = inputLocation;
        }
        public void setStreetDetails(string inputStreet)
        {
            StreetNumberAndName = inputStreet;
        }
        public void setCounty(string inputCounty)
        {
            county = inputCounty;
        }
        public void setPostcode(string inputPostcode)
        {
            postcode = inputPostcode;
        }
        public void setLongitude(float inputLongitude)
        {
            longitude = inputLongitude;
        }
        public void setLatitude(float inputLatitude)
        {
            latitude = inputLatitude;
        }
        public void setYears(int inputYears)
        {
            yearsInDataset = inputYears;
        }

    }
}
