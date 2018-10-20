using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pierwszy
{
    class Program
    {
        static int Main(string[] args)
            {
            Program1(false);

            Program2(false);
            
            Program3(false);

            Program4(true);

           
            return 100;   
        }

        private static void Program4(bool i)
        {
            int wynik = 0;
            int[] zmienna= new int[5] {2,5,8,12,36};
            
         if (i) {
            
          /*      zmienna[0] = 2;
                zmienna[1] = 5;
                zmienna[2] = 8;
                zmienna[3] = 12;
                zmienna[4] = 36; */
                Console.Write("\r\nDLA LICZB :"); 
                foreach (int item in zmienna)
	{
                 if (item != 0)
                  {
                    Console.Write("{0}, ",item);
                    wynik = wynik + item;
                  }
	}
            
            Console.Write("\r\n\nSUMA WYNOSI: {0}\r\n\n",wynik);
            Console.ReadKey();
         }
        }

        private static void Program3(bool i)
        {
         if (i) {
            string  linia1 = @"111     +     222     =     333 ";
            string  linia2 = @" +             +             +  ";
            string  linia3 = @"333     +     444     =     777 ";
            string  linia4 = @" =             =             =  ";
            string  linia5 = @"444     +     666      =    1100";
            Console.Write("\r\n{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}\r\n\n",linia1,linia2,linia3,linia4,linia5);
            Console.ReadKey();
         }
        }
        private static void Program2(bool i)
        {
        if (i) {
            string  linia1 = @" /---\  |----\  /----\";
            string  linia2 = @"|     | |     | |     ";
            string  linia3 = @"|     | |    /  |     ";
            string  linia4 = @"|-----| |----   |     ";
            string  linia5 = @"|     | |    \  |     ";
            string  linia6 = @"|     | |     | |     ";
            string  linia7 = @"|     | |----/  \----/";
                   
            Console.Write("\r\n{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}\r\n{5}\r\n{6}\r\n\n",linia1,linia2,linia3,linia4,linia5,linia6,linia7);
            Console.ReadKey();
           
            }
        }
        private static void Program1(bool i)
        {
         if (i) {
            double a= 14.5;
            double b=24.45;
    
            Console.Write("\r\nLiczba 1 to {0} \t\nLiczba 2 to {1}\r\n\n",a,b);
           
            Console.ReadKey();
         }
        }








    }
}
