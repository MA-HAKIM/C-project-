using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01.Models
{
    public class HourlyPaidWorker:Worker
    {
        public HourlyPaidWorker() : base() { }
        public HourlyPaidWorker(int id, string name, string phone,  decimal payRate, int perDayWorkHour) 
            : base(id, name, phone) {
            this.WorkHourPerDay = perDayWorkHour;
            this.PayRate = payRate;
        }
        public int WorkHourPerDay { get; set; }
        public decimal PayRate { get; set; }

        public override string Describe()
        {
            return $"Id={WorkerId} Name={Name}, Phone={Phone}\n" +
                   $"Hourly pay worker Pay Rate={PayRate} Works per day {WorkHourPerDay} hours";
        }
    }
}
