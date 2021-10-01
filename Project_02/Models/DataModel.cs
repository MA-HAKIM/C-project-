using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_02.Models
{
    public enum TradeCode { Welding, Carpentry, Plumbing}
    public class Trade
    {
        public int TradeId { get; set; }
        public TradeCode Code { get; set; }
        public int TotalTraingHour { get; set; }
    }
    public class Trainee
    {
        public int TraineeId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public int TradeId { get; set; }
    }
}
