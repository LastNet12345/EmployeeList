using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList
{
    public class Robot
    {
        private string firstname;
        private int age;

        //private int length;

        //public int Length
        //{
        //    get { return length; }
        //    set { length = value; }
        //}

        public int Length { get; set; }
       
        // public int Length2;


        //public Robot()
        //{

        //}

        public Robot(string name, int age)
        {
            //Validate
            this.age = age;
            firstname = name;
        }

        public void SetFirstName(string newFirstName)
        {
            //Validate
            firstname = newFirstName;
        }

        public string GetFirstName()
        {
            return firstname;
        }
    }
}
