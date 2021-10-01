using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01.Models
{
    public interface IPayCalculator<in T>
    {
        decimal CalculatePayment(T obj, int year, int month);
    }
}
