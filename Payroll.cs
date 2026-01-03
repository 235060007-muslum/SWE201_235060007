using System;

namespace EmployeeTaskApp1
{
    public class Payroll
    {
        public double CalculateSalary(Employee employee)
        {
            double totalHours = 0;

            foreach (var task in employee.Tasks)
            {
                if (task.IsCompleted)
                {
                    totalHours += task.HoursWorked;
                }
            }

            return totalHours * employee.HourlyRate;
        }
    }
}