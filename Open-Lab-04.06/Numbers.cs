using System;
using System.Collections.Generic;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            List<int> a = new List<int> { };
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                      a.Add(i) ;
                }
            }
            return a.ToArray();
        }
    }
}
