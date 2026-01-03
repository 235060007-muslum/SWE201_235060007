using System;

namespace EmployeeTaskApp1
{
    public class EmployeeTask
    {
        public string Title { get; set; }
        public int HoursWorked { get; private set; }
        public bool IsCompleted { get; private set; }

        public EmployeeTask(string title)
        {
            Title = title;
            HoursWorked = 0;
            IsCompleted = false;
        }

        public void CompleteTask(int hours)
        {
            HoursWorked = hours;
            IsCompleted = true;
        }
    }
}