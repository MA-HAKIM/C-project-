using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01.Models
{
    public abstract class Worker
    {
        public Worker() { }
        public Worker(int id, string name, string phone)
        {
            this.WorkerId = id; this.Name = name; this.Phone = phone; 
        }
        public int WorkerId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public abstract string Describe();
       
    }
}
