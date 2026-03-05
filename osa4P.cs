using System;
using System.Collections.Generic;
using System.Text;

namespace PraktilinetöödVitaliiAB
{
    internal class osa4P
    {
        public static void ItalToit()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt"); //@"..\..\..\Kuud.txt"
                StreamWriter text = new StreamWriter(path, true); // true = lisa lõppu
                Console.WriteLine("Sisesta min 2 itaalia toidu: ");
                string lause = Console.ReadLine();
                text.WriteLine(lause);
                text.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga");
            }
        }
        public static List<string> retseptid_loe()
        {
            List<string> toit_list = new List<string>();
            try
            {
                string path = @$"..\..\..\Retseptid.txt";
                foreach (string rida in File.ReadAllLines(path))
                {
                    toit_list.Add(rida);
                }
                foreach (string i in toit_list) Console.WriteLine(i);
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga");
            }
            return toit_list;
        }

    }
}
