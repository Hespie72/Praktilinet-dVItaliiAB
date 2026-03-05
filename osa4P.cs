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
        public static void retseptid_loe()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");
                StreamReader text = new StreamReader(path);
                string laused = text.ReadToEnd();
                text.Close();
                Console.WriteLine(laused);
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
            }


        }
        public static void Muuda_Engredient()
        {
            try
            {

            }
            catch (Exception d)
            {

                Console.WriteLine(d);
            }
        }

    }
}
