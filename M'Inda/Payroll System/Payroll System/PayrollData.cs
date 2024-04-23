using PayrollData;

namespace PayrollData
{
    public class PayrollData
    {
        private List<Employee> employees;

        public PayrollData()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public Employee GetEmployeeById(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);

             List<Employee> GetAllEmployees()
            {
                return employees;
            }
        }

        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double HourlyRate { get; set; }
            public double HoursWorked { get; set; }
        }
    }
}
