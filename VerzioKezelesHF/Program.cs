using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzioKezelesHF
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[10];
            Console.WriteLine("Kérem adjon meg 10 számot:");
            
            for (int i = 0; i < szamok.Length; i++)
            {

             int h = Convert.ToInt32(Console.ReadLine());
                szamok[i] = h;
            }
            int atlag = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                atlag = atlag + szamok[i];
            }
            Console.WriteLine("A számok átlaga : " + atlag/szamok.Length);
            Console.ReadKey();
        }
    }
}
