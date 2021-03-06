using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class DataOperation
    {
        public List<(string cutomerName, double purchaseAmount, DateTime purchaseDate)>
        MergeData(List<Customer> customers, List<Purchase> purchases)
        {
            ValueTuple<string, double, DateTime> info;

            List<(string cutomerName, double purchaseAmount, DateTime purchaseDate)> res
                                     = new List<ValueTuple<string, double, DateTime>>();

            var res1 =  from c in customers
                        join p in purchases
                        on c.Id equals p.CustomerId
                        select 
                       ( info.Item1= c.Name, info.Item2 = p.Amount, info.Item3 =  p.PurchasedOn);

           res.AddRange(res1);
           return res;
        }
    }
}
