using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Entities;
using Utilities;

namespace DataAccess
{
    public class DataAccess
    {
        public List<Employee> employee  = new List<Employee>();
        private static string directory = @"C:\Users\BJ\Documents\C# projects";
        private static string fileName = "Employee.txt";

        public void RegisterEmployee(Employee employees)
        {

            string path = $"{directory}{fileName}";

            using (StreamWriter writer = new(path, append: true))
            {
                StringBuilder sb = new();
                sb.Append($"FirstName:{employees.FirstName};");
                sb.Append($"LastName:{employees.LastName};");
                sb.Append($"Email:{employees.Email};");
                sb.Append($"PhoneNumber:{employees.PhoneNumber};");
                sb.Append($"State:{employees.State} ;");
                sb.Append($"Department:{employees.Department} ;");
                sb.Append($"Salary:{employees.Salary} ;");

                writer.WriteLine(sb.ToString());
            }
        }

        public void DeleteEmployee(string email)
        {
            string path = $"{directory}{fileName}";


            string[] lines = File.ReadAllLines(path);
            bool found = false;

            var updatedRecords = lines.Where(line =>
            {
                string[] employeeSplit = line.Split(';');
                string splitEmail = employeeSplit[2].Substring(employeeSplit[2].IndexOf(':') + 1);

                if (splitEmail == email)
                {
                    found = true;
                    return false;
                }

                return true;

            }).ToArray();

            if (found)
            {
                File.WriteAllLines(path, updatedRecords);
            }
        }

        public bool ExistingEmail(string email)
        {
            string path = $"{directory}{fileName}";

            string[] lines = File.ReadAllLines(path);

            bool isEmailExist = lines.Any(line =>
            {
                string[] employeeSplit = line.Split(';');

                string splitEmail = employeeSplit.FirstOrDefault(e => e.Trim().StartsWith("Email:", StringComparison.OrdinalIgnoreCase));

                if (splitEmail != null)
                {
                    // Get the email part after "Email:"
                    string emailPart = splitEmail.Substring("Email:".Length).Trim();

                    // Compare the extracted email with the provided email
                    return emailPart.Equals(email, StringComparison.OrdinalIgnoreCase);
                }

                return false;
            });

            return isEmailExist;
        }


        public Employee GetEmployeeByEmail(string email)
        {
           string path = $"{directory}{fileName}";

            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Employee file not found.");
            }

            using (StreamReader reader = new(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] employeeSplit = line.Split(';');
                    string splitEmail = employeeSplit.FirstOrDefault(e => e.Trim().StartsWith("Email:", StringComparison.OrdinalIgnoreCase));

                    if (splitEmail != null)
                    {
                        string emailPart = splitEmail.Substring("Email:".Length).Trim();

                        if (emailPart.Equals(email, StringComparison.OrdinalIgnoreCase))
                        {
                            return ConstructEmployeeFromLine(employeeSplit);
                        }
                    }
                }
            }

            return null;
        }

        private Employee ConstructEmployeeFromLine(string[] segments)
        {
            Employee employee = new Employee();

            foreach (string segment in segments)
            {
                string[] parts = segment.Split(':');

                if (parts.Length == 2)
                {
                    string key = parts[0].Trim();
                    string value = parts[1].Trim();

                    switch (key)
                    {
                        case "FirstName":
                            employee.FirstName = value;
                            break;
                        case "LastName":
                            employee.LastName = value;
                            break;
                        case "Email":
                            employee.Email = value;
                            break;
                        case "PhoneNumber":
                            employee.PhoneNumber = value;
                            break;
                        case "State":
                            employee.State = value;
                            break;
                        case "Department":
                            employee.Department = value;
                            break;
                        case "Salary":
                            employee.Salary = value;
                            break;
                    }
                }
            }

            return employee;
        }

        public List<Employee> viewAllEmployees()
        {
            string path = $"{directory}{fileName}";
            if (!File.Exists(path))
            {
                throw new Exception("Employees not found");
            }

            List<Employee> employee = new List<Employee>();
            
            using (StreamReader reader = new(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] employeeSplit = line.Split(';');
                    Employee employees = ConstructEmployeeFromLine(employeeSplit);
                    employee.Add(employees);

                }
            }

            return employee;
        }

        
    }
}
