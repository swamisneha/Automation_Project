using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo.Utilities
{
    public class DataSaurce
    {
        public static object[] InvalidLoginTestData()
        {
            string[] dataSet1 = new string[3];
            dataSet1[0] = "john";
            dataSet1[1] = "john123";
            dataSet1[2] = "Epic sadface";

            string[] dataSet2 = new string[3];
            dataSet2[0] = "peter";
            dataSet2[1] = "peter123";
            dataSet2[2] = "Epic sadface";


            object[] allDataSet = new object[2]; //Number of test cases
            allDataSet[0] = dataSet1;
            allDataSet[1] = dataSet2;
       
            return allDataSet;

        }
    }
}
