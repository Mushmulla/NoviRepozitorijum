using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanojskeKuuuule
{
    class Program
    {
        class HanojskeKule
        {
            public void SrediPrstenove(int brojPrstenova, char Source, char Tmp, char Destination)
            {
                if (brojPrstenova < 1)
                {
                    return;
                }
                if (brojPrstenova == 1)
                {
                    Console.WriteLine($"Prebacuje se prsten {brojPrstenova} sa {Source} na {Destination}");
                    return;
                }
                SrediPrstenove(brojPrstenova - 1, Source, Destination, Tmp);
                Console.WriteLine($"Prebacuje se prsten {brojPrstenova} sa {Source} na {Destination}");
                SrediPrstenove(brojPrstenova - 1, Tmp, Source, Destination);



            }


             static void Main(string[] pera)
             {
                HanojskeKule hk = new HanojskeKule();
                hk.SrediPrstenove(16, 'a', 'b', 'c');

                Console.ReadLine();
             }
        }
    }
    
}
