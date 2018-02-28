using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{ 
    abstract partial class Employee
    {
        // field data
        protected string empName;
        protected int empID;
        protected float currPay;
        protected int empAge;
        protected string empSSN;


        //  ctors
        public Employee()
        {
        }

        public Employee(string name, int id, float pay) : this(name, 0, id, pay, "")
        {
        }

        public Employee(string name, int age, int id, float pay, string ssn)
        {
            Name = name;
            ID = id;
            Age = age;
            Pay = pay;
            empSSN = ssn;
        }
    }
}
