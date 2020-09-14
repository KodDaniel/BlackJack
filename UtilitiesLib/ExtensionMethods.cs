using System;
using System.Collections.Generic;
using System.Text;

namespace UtilitiesLib
{
    public static class ExtensionMethods 
    {
        public static void Shuffle<T>(this List<T> list)
        {
            Random random = new Random();
            int n = list.Count;
           
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                var value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }


    }


}

