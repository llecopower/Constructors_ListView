using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Constructors_ListView.DataAccess
{
    public static class EmployeeIO
    {
        //Location where the data will be saved
        const string dir = @"";

        //the name of the storage
        const string filePath = dir + "employee.dat";

        public static void SaveRecord(Employee emp)
        {
            StreamWriter sWriter = new StreamWriter(filePath,true);
            sWriter.WriteLine(emp.EmployeeId + "," + emp.FirstName + "," + emp.LastName);
      
            MessageBox.Show("Recorded saved Successfully");
            sWriter.Close();
       
        }



        public static Employee SearchRecord(int id)
        {
            Employee emp = new Employee();
            if (File.Exists(filePath))
            {
                //Create the object of readtype!!!!!
                StreamReader sReader = new StreamReader(filePath);
                string line = sReader.ReadLine();
            }

            return emp;
        }





    }
}
