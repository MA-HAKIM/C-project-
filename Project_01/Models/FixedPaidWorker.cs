using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01.Models
{
    public class FixedPaidWorker: Worker
    {

        public FixedPaidWorker() : base() { }
        public FixedPaidWorker(int id, string name, string phone, decimal fixedPay, decimal mealAllowance)
            :base(id, name, phone)
        {
            this.FixedPay = fixedPay;
            this.MealAllowancePerDay = mealAllowance;
        }
        public decimal FixedPay { get; set; }
        public decimal MealAllowancePerDay { get; set; }

        public override string Describe()
        {
            return $"Id={WorkerId} Name={Name}, Phone={Phone}\n" +
                    $"Fixed pay worker Fix Pay={FixedPay} meal allowance @ {MealAllowancePerDay}";
        }
    }
}
