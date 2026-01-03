using System;
using System.Collections.Generic;

namespace EmployeeTaskApp1
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double HourlyRate { get; set; }

        public List<EmployeeTask> Tasks { get; set; }

        public Employee(int id, string name, double hourlyRate)
        {
            Id = id;
            Name = name;
            HourlyRate = hourlyRate;
            Tasks = new List<EmployeeTask>();
        }

        public void AssignTask(EmployeeTask task)
        {
            Tasks.Add(task);
        }
    }
}