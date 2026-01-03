using System;

namespace EmployeeTaskApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Employee employee1 = new Employee(1, "Müslüm Kötüz", 100);

           
            EmployeeTask task1 = new EmployeeTask("Backend geliştirme");
            EmployeeTask task2 = new EmployeeTask("Veritabanı düzenleme");

          
            employee1.AssignTask(task1);
            employee1.AssignTask(task2);

            
            task1.CompleteTask(6);
            task2.CompleteTask(11);

           
            Payroll payroll = new Payroll();
            double salary = payroll.CalculateSalary(employee1);

 
            Console.WriteLine("Çalışan Adı: " + employee1.Name);
            Console.WriteLine("Toplam Görev Sayısı: " + employee1.Tasks.Count);
            Console.WriteLine("Hesaplanan Maaş: " + salary + " TL");

            Console.ReadLine();
        }
    }
}