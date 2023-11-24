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
        private static string departmentFileName = "Department.txt";

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

        public void AddDepartment(Departments department)
        {
            string path = $"{directory}{departmentFileName}";

            using(StreamWriter writer = new(path, append: true))
            {
                StringBuilder sb = new();
                sb.Append($"Department:{department.Department};");
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

        private Departments ConstructDepartmentFromLine(string[] segments)
        {
            Departments departments = new();
            foreach(string segment in segments)
            {
                string[] parts = segment.Split(':');
                if (parts.Length == 2)
                {
                    string key = parts[0].Trim();
                    string value = parts[1].Trim();

                    switch (key)
                    {
                        case "Department":
                            departments.Department = value;
                            break;
                    }
                }
            }
            return departments;
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

        public Dictionary<decimal, List<Employee>> GroupBySalary()
        {
            List<Employee> employees = viewAllEmployees();

            var filteredEmployees = employees.Where(emp =>
            {
                if (decimal.TryParse(emp.Salary, out decimal salary))
                {
                    return salary >= 150000 && salary <= 300000;
                }
                return false; // Salary parsing failed or not in the valid range
            });

            var groupBySalary = filteredEmployees
                .GroupBy(emp =>
                {
                    // Convert Salary string to decimal for grouping
                    return decimal.Parse(emp.Salary);
                })
                .ToDictionary(g => g.Key, g => g.ToList());

            return groupBySalary;
        }

        public List<string> EmployeesWithNoDepartment()
        {
            List<string> employeeWithoutDepartent = new List<string>();
            List<string> departentWithoutEmployee = new List<string>();
            List<Employee> employees = viewAllEmployees();
            List<Departments> departments = viewAllDepartment();

            /*var employeeWithNoDepartment = employees.Where(emp => !departments.Any(dep => dep.Department == emp.Department));*/
            var departmentWithNoEmployee = departments.Where(dep => !employees.Any(emp => emp.Department == dep.Department));
            foreach (var dep in departmentWithNoEmployee)
            {
                departentWithoutEmployee.Add(dep.Department);
            }
            return departentWithoutEmployee;
        }
        public List<string> GroupByDepartment()
        {
            List<string> employeeWithDepartent = new List<string>();
            List<Employee> employees = viewAllEmployees();
            List<Departments> departments = viewAllDepartment();

            foreach(var deparment in departments)
            {

                var employeeInDepratment = employees.Where(emp => emp.Department == deparment.Department).ToList();

                if (employeeInDepratment.Any())
                {
                    employeeWithDepartent.Add(deparment.Department);
                    foreach(var emp in employeeInDepratment)
                    {
                        employeeWithDepartent.Add($"{emp.FirstName}");
                    }
                    employeeWithDepartent.Add("");     
                }
            }
            return employeeWithDepartent;
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

        public List<Departments> viewAllDepartment()
        {
            string path = $"{directory}{departmentFileName}";
            if (!File.Exists(path))
            {
                throw new Exception("Department not found");
            }

            List<Departments> departments = new List<Departments>();
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] departmentSplit = line.Split(';');
                    Departments department = ConstructDepartmentFromLine(departmentSplit);
                    departments.Add(department);

                }
            }

            return departments;
        }

        public List<string> GetAllDepartments()
        {
            string path = $"{directory}{departmentFileName}";

            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Departments file not found.");
            }

            List<string> departments = new List<string>();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    departments.Add(line);
                }
            }

            return departments;
        }


        public void UpdateDepartmentInEmployee(string email, string department)
        {
            string path = $"{directory}{fileName}";
            string tempFile = $"{directory}temp_{fileName}";

            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Employee file not found.");
            }

            bool updated = false;

            using (StreamReader reader = new StreamReader(path))
            using (StreamWriter writer = new StreamWriter(tempFile, false))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] employeeSplit = line.Split(';');
                    string splitEmail = employeeSplit.FirstOrDefault(e => e.Trim().StartsWith("Email:", StringComparison.OrdinalIgnoreCase));

                    string splitDepartment = employeeSplit.FirstOrDefault(e => e.Trim().StartsWith("Department:", StringComparison.OrdinalIgnoreCase));

                    if (splitEmail != null)
                    {
                        string emailPart = splitEmail.Substring("Email:".Length).Trim();

                        if (emailPart.Equals(email, StringComparison.OrdinalIgnoreCase))
                        {
                            if(splitDepartment != null)
                            {
                                //replace existing department
                                string updatedLine = line.Replace(splitDepartment, $"Department:{department}");
                                writer.WriteLine(updatedLine);
                            }
                            else
                            {
                                //if no department exist add it
                                writer.WriteLine($"{line};Department:{department}");
                            }
                            updated = true;
                            continue;
                        }
                    }

                    writer.WriteLine(line);
                }
            }

            if (updated)
            {
                File.Delete(path);
                File.Move(tempFile, path);
            }
            else
            {
                File.Delete(tempFile);
            }
        }

    }
}
