using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LirbraryClass
    {
        public string Time(DateTime current, DateTime start)
        {
            int result = Math.Abs(start.Subtract(current).Minutes);
            string min = "минут";

            if (result % 100 >= 11 & result % 100 <= 20) min = "минут";
            else if (result % 10 == 1) min = "минута";
            else if (result % 10 >= 2 && result % 10 <= 4) min = "минуты";

            return $"Время работы приложения - {result} {min}";
        }

        public void Sort(ref double[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int ind = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[ind])
                    {
                        ind = j;
                    }
                }
                double value = arr[ind];
                arr[ind] = arr[i];
                arr[i] = value;
            }
        }
    }
}