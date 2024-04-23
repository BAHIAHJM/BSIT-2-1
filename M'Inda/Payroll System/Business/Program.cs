using PayrollBusiness;

namespace PayrollBL
{
    public class PayrollService
    {
        private EmployeeDataLayer dataLayer;

        public PayrollService()
        {
            dataLayer = new EmployeeDataLayer();
        }

        // Add a new employee
        public void AddEmployee(int id, string name, double hourlyRate)
        {
            Employee employee = new Employee { Id = id, Name = name, HourlyRate = hourlyRate };
            dataLayer.AddEmployee(employee);
        }

        // Calculate the payroll for an employee
        public double CalculatePayroll(int id)
        {
            Employee employee = dataLayer.GetEmployeeById(id);
            if (employee == null)
            {
                throw new Exception("Employee not found");
            }

            return employee.HoursWorked * employee.HourlyRate;
        }

        // Update employee's hours worked
        public void UpdateHoursWorked(int id, double hours)
        {
            Employee employee = dataLayer.GetEmployeeById(id);
            if (employee == null)
            {
                throw new Exception("Employee not found");
            }

            employee.HoursWorked = hours;
        }
    }
}