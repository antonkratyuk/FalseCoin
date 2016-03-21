using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalseCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            double[]arr = new double[21];

            valueRandom.FillArray(ref arr);
            valueRandom.RandCoin(ref arr);
            valueRandom.ShowArray(arr);

            Console.WriteLine(valueRandom.falseWeight(arr)); 


            
        }
    }
}
