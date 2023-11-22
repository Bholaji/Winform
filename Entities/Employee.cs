using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee
    {
        private Guid id;
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private string state;
        private string department;
        private string salary;
        
        public Guid Id
        {
            get;set;
        }
        public string FirstName {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value;}
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public string Salary
        {
            get { return salary; }
            set { salary = value; }
        }

    }
}
