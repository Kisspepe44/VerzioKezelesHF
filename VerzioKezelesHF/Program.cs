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
            Console.WriteLine("Kérem adja mág hány számot szeretne megadni: ");
            int[] szamok = new int[Convert.ToInt32(Console.ReadLine())];
            Console.WriteLine("Kérem adja meg a {0} számot:",szamok.Length ) ;
            
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
            int max = szamok[0];
            for (int i = 0; i < szamok.Length; i++)
            {
                
                if (szamok[i] > max)
                {
                    max = szamok[i];
                }
            }
            Console.WriteLine("A megadott számok közül a legnagyobb a(z) " + max);
            int min = szamok[0];
            for (int i = 0; i < szamok.Length; i++)
            {

                if (szamok[i] < min)
                {
                    min= szamok[i];
                }
            }
            Console.WriteLine("A megadott számok közül a legkissebb a(z) " + min);


            Console.ReadKey();
        }
    }
}
