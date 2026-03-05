using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
Console.OutputEncoding = Encoding.UTF8;

namespace PraktilinetöödVitaliiAB
{
    public class StartPage
    {
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Valik 1-5 \n 1.Luua faili Retseptid \n 2.Loe fail \n \n \n ");
                int valik = int.Parse(Console.ReadLine());
                if (valik == 1)
                {
                    osa4P.ItalToit(); break;
                }
                else if (valik == 2)
                {
                    osa4P.retseptid_loe(); break;
                }
            }
        }
    }
}