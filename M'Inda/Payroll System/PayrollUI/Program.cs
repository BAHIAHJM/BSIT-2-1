using ProgramBusiness;

namespace PayrollUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PayrollService payrollService = new PayrollService();

            while (true)
            {
                Console.WriteLine("\nPayroll System:");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Update Hours Worked");
                Console.WriteLine("3. Calculate Payroll");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 4)
                {
                    break;
                }

                switch (choice)
                {
                    case 1:
                        AddEmployee(payrollService);
                        break;
                    case 2:
                        UpdateHoursWorked(payrollService);
                        break;
                    case 3:
                        CalculatePayroll(payrollService);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void AddEmployee(PayrollService payrollService)
        {
            Console.Write("Enter Employee ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Hourly Rate: ");
            double hourlyRate = double.Parse(Console.ReadLine());

            payrollService.AddEmployee(id, name, hourlyRate);
            Console.WriteLine("Employee added successfully.");
        }

        static void UpdateHoursWorked(PayrollService payrollService)
        {
            Console.Write("Enter Employee ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Hours Worked: ");
            double hours = double.Parse(Console.ReadLine());

            payrollService.UpdateHoursWorked(id, hours);
            Console.WriteLine("Hours worked updated successfully.");
        }

        static void CalculatePayroll(PayrollService payrollService)
        {
            Console.Write("Enter Employee ID: ");
            int id = int.Parse(Console.ReadLine());

            double payroll = payrollService.CalculatePayroll(id);
            Console.WriteLine($"Payroll for Employee ID {id}: ${payroll:F2}");
        }
    }
}