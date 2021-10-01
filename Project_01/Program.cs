using Project_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[]
            {
                new FixedPaidWorker { WorkerId=1, Name="Kashem Mia", Phone="01911090909", FixedPay=10000.00M, MealAllowancePerDay=130.00M},
                new FixedPaidWorker { WorkerId=2, Name="Abul Hashem", Phone="01711090905", FixedPay=95000.00M, MealAllowancePerDay=130.00M},
                new FixedPaidWorker { WorkerId=3, Name="Abdul Baten", Phone="01611090909", FixedPay=10500.00M, MealAllowancePerDay=130.00M},
                new HourlyPaidWorker{ WorkerId=4, Name="Rahmat Ali", Phone="01811010101", WorkHourPerDay=8, PayRate=100.00M},
                new HourlyPaidWorker{ WorkerId=5, Name="Abul Hasan", Phone="01911020202", WorkHourPerDay=8, PayRate=90.00M},
                new HourlyPaidWorker{ WorkerId=6, Name="Babul Hossain", Phone="01811010101", WorkHourPerDay=8, PayRate=85.00M}
            };
            MonthPaymentCalculator<Worker> calcular = new MonthPaymentCalculator<Worker>();
            foreach(var w in workers)
            {
                Console.WriteLine(w.Describe());
                decimal pn = calcular.CalculatePayment(w, 2020, 11);
                Console.WriteLine($"Payment Nov, 2020: {pn:0.00}");
                decimal pd = calcular.CalculatePayment(w, 2020, 12);
                Console.WriteLine($"Payment Dec, 2020: {pd:0.00}");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
