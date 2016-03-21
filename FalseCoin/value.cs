using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalseCoin
{
    static class valueRandom
    {
        public static void FillArray(ref double [] array)
        {
            Random rand = new Random();
            double val = rand.NextDouble();
            for (int key = 0; key < array.Length; ++key)
            {
                array[key] = Math.Round(val, 3);
            }

        }

        public static void RandCoin(ref double []array)
        {
            Random rand = new Random();        

            array[(int)rand.Next(array.Length - 1)] = rand.NextDouble();
        }
        public static bool ShowArray(double[]arr)
        {
            if (arr.Length == 0)
                return false;
            else
            {
                for (int  key =0; key < arr.Length; ++key)
                    Console.Write(arr[key] + " ");
                return true;
                
            }
        }  
        private static double Sum(double[]arr, int begin, int end)
        {
            double sum = 0;
            for (int i = begin; i < end; ++i)
                sum += arr[i];

            return sum;
        }


        static void swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
        static bool findHarder(double[]arr)
        {
            if (valueRandom.Sum(arr, 0, 10) < valueRandom.Sum(arr, 10, 20))
                return true;
            else
                return false;
        }

        public static string falseWeight(double[]arr)
        {
            if(valueRandom.Sum(arr, 0, 10) == valueRandom.Sum(arr, 10, 20))
            {
                valueRandom.swap(ref arr[19], ref arr[20]);
                if (valueRandom.Sum(arr, 10, 20) > valueRandom.Sum(arr, 0, 10))
                    return "Harder";
                else
                    return "Lighter";
            }
            else
            {
                if(findHarder(arr))//WET!!!! But in other case I should copy array into splited once
                {
                    if (valueRandom.Sum(arr, 10, 15) == valueRandom.Sum(arr, 15, 20))
                        return "Lighter";
                    return "Harder";

                }
                else
                {
                    if (valueRandom.Sum(arr, 0, 5) == valueRandom.Sum(arr, 5, 10))//WET
                        return "Lighter";
                    return "Harder";
                }


            }

        }    

    }
}
