﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Constructors_ListView.DataAccess;

namespace Constructors_ListView
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }


        public void SaveEmployee(Employee emp)
        { 
            EmployeeIO.SaveRecord(emp);
        
        }

        public Employee SearchEmployee(int id)
        {
           return EmployeeIO.SearchRecord(id);
        }


    }
}
