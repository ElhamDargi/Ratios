using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr =new List<int>() {1, 2 ,3, -1 ,-2 ,-3, 0, 0};
            var negativeNum = 0;
            var zeroNum = 0;
            var positiveNum = 0;
            var rangelength = arr.Count;
            if (rangelength == 0)
            {
                Console.WriteLine("No array exist");
            }
            else
            {
                foreach (var item in arr)
                {
                    switch (item)
                    {
                        case < 0:
                            negativeNum++;
                            break;
                        case 0:
                            zeroNum++;
                            break;
                        default:
                            positiveNum++;
                            break;
                    }
                }
                Console.WriteLine("{0:0.000000}", decimal.Divide(positiveNum, rangelength));
                Console.WriteLine("{0:F6} ", decimal.Divide(negativeNum, rangelength));
                Console.WriteLine("{0:0.000000}", decimal.Divide(zeroNum, rangelength));
              

                //Console.WriteLine("{0:F6} ", negativeNum / rangelength);
                //Console.WriteLine("{0:F6} ", zeroNum / rangelength);
                //Console.WriteLine("{0:F6} ", positiveNum / rangelength);

                Console.ReadKey();
            }
        }
    }
}
