using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Math
{
    public static class Statistics
    {
        public static decimal GetMean(in IEnumerable<decimal> values)
        {
            decimal sum = 0;

            foreach (decimal result in values)
            {
                sum += result;
            }

            return sum / values.Count();
        }

        //public static decimal GetMode(IEnumerable<decimal> values)
        //{
        //    Dictionary<decimal, int> frequencies = new Dictionary<decimal, int>();

        //    foreach (decimal value in values)
        //    {
        //        if (frequencies.ContainsKey(value))
        //        {
        //            frequencies[value]++;
        //        }
        //        else
        //        {
        //            frequencies.Add(value, 1);
        //        }
        //    }

            
        //}

        //public static decimal GetMedian(IEnumerable<decimal> values)
        //{
            
        //}
    }
}
