using Project_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Collection and initializing data
             * 
             * */
            List<Trade> trades = new List<Trade>
            {
                new Trade { TradeId=1, Code= TradeCode.Welding, TotalTraingHour=100},
                new Trade { TradeId=2, Code= TradeCode.Carpentry, TotalTraingHour=110},
                new Trade { TradeId=3, Code= TradeCode.Plumbing, TotalTraingHour=80}
            };
            List<Trainee> trainees = new List<Trainee> {
                new Trainee{ TraineeId=1, Name="Rustom Ali", Phone="01772321321", BirthDate=new DateTime(2002, 7, 11), TradeId=1},
                new Trainee{ TraineeId=2, Name="Towhidul Islam", Phone="01775121212", BirthDate=new DateTime(2002, 3, 4), TradeId=1},
                new Trainee{ TraineeId=3, Name="Azim Mina", Phone="01552908765", BirthDate=new DateTime(2001, 11, 3), TradeId=1},
                new Trainee{ TraineeId=4, Name="Imtiaz Faisal", Phone="01675566565", BirthDate=new DateTime(2002, 7, 11), TradeId=1},
                new Trainee{ TraineeId=5, Name="Reyad Khan", Phone="01770554433", BirthDate=new DateTime(2002, 5, 27), TradeId=1},
                new Trainee{ TraineeId=6, Name="Masud Rana", Phone="01991009988", BirthDate=new DateTime(2002, 1, 7), TradeId=3},
                new Trainee{ TraineeId=7, Name="Abdul Hakim", Phone="01554123113", BirthDate=new DateTime(2002, 11, 7), TradeId=3},
                new Trainee{ TraineeId=8, Name="Kamrul Islam", Phone="01771761209", BirthDate=new DateTime(2002, 3, 11), TradeId=3},
                new Trainee{ TraineeId=9, Name="Asad Bishwash", Phone="01675010208", BirthDate=new DateTime(2002, 4, 21), TradeId=3}
            };
            Console.WriteLine("Trade wise trainees");
            Console.WriteLine();

            trades
                .ForEach(t =>
                {
                    Console.WriteLine("Trade");
                    Console.WriteLine($"Id={t.TradeId}\tCode={t.Code}\tTotal Hour={t.TotalTraingHour}");
                    Console.WriteLine("Trainees");
                    trainees
                     .Where(r => r.TradeId == t.TradeId)
                     .ToList<Trainee>()
                     .ForEach(r =>
                     {
                         Console.WriteLine($"\tId={r.TraineeId}\tName={r.Name}\tPhone={r.Phone}\tDOB={r.BirthDate:yyyy-MM-dd}");
                     });
                    Console.WriteLine();
                });
            Console.WriteLine();
            Console.WriteLine("Trades: sort on training hour ascending, Code descending");
            Console.WriteLine();
            trades
                .OrderBy(t=> t.TotalTraingHour)
                .ThenByDescending(t=> t.Code)
                .ToList()
                .ForEach(t => {
                    Console.WriteLine($"Id={t.TradeId}\tCode={t.Code}\tTotal Hour={t.TotalTraingHour}");
                });
            Console.WriteLine();
            Console.WriteLine("Join: inner");
            Console.WriteLine();
            trades
                .Join(
                trainees,
                        t => t.TradeId,
                        r => r.TradeId,
                        (t, r) => new { t.Code, t.TotalTraingHour, r.Name, r.Phone, r.BirthDate }
                        )
                .ToList()
                .ForEach(t => {
                    Console.WriteLine($"Code={t.Code}\tTotal Hour={t.TotalTraingHour}\tName={t.Name}\tPhone={t.Phone}\tDOB={t.BirthDate:yyyy-MM-dd}");
                });
            Console.WriteLine();
            Console.WriteLine("Join: left outer");
            Console.WriteLine();
            var q = from t in trades
                    join r in trainees on t.TradeId equals r.TradeId into tr
                    from r in tr.DefaultIfEmpty()
                    select new { t.Code, t.TotalTraingHour, r?.Name, r?.Phone, r?.BirthDate };
            foreach(var t in q)
            {
                Console.WriteLine($"Code={t.Code}\tTotal Hour={t.TotalTraingHour}\tName={t.Name}\tPhone={t.Phone}\tDOB={t.BirthDate:yyyy-MM-dd}");
            }
            Console.ReadLine();
        }
    }
}
