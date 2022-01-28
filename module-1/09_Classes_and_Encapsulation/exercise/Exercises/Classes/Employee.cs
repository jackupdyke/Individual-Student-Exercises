﻿namespace Exercises.Classes
{
    public class Employee
    {

        public Employee(int employeeId, string firstName, string lastName, double salary)
        {

            EmployeeId = employeeId;

            FirstName = firstName;

            LastName = lastName;

            AnnualSalary = salary;

        }

        public int EmployeeId { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        public string Department { get; set; }

        public double AnnualSalary { get; private set; }

        public void RaiseSalary(double percent)
        {
            AnnualSalary = AnnualSalary * (1 + percent / 100);
        }


    }
}
