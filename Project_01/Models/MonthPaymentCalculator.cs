using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01.Models
{
    public class MonthPaymentCalculator<T> : IPayCalculator<T> where T : Worker
    {
        public decimal CalculatePayment(T obj, int year, int month)
        {
            int days = DateTime.DaysInMonth(year, month);
            if (obj is FixedPaidWorker)
            {
                FixedPaidWorker w = obj as FixedPaidWorker;
               
                return days * (w.FixedPay + w.MealAllowancePerDay);
            }else if(obj is HourlyPaidWorker)
            {
                HourlyPaidWorker w = obj as HourlyPaidWorker;

                return days * w.PayRate * w.WorkHourPerDay;
            }
            else
            {
                throw new ArgumentException("Passed arguament is not a valid worker type.");
            }

        }
    }
}
