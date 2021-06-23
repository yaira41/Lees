using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeesBirthClass.Enums;

namespace LeesBirthClass.Employees
{
    class Employee
    {
        public Employee(string firstName, string lastName, List<Ranks> ranks)
        {
            Id = Guid.NewGuid().ToString();
            FirstName = firstName;
            LastName = lastName;
            Ranks = ranks;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string Id { get; private set; }

        public List<Ranks> Ranks { get; set; }

        public float Salary { get; set; }


    }
}
