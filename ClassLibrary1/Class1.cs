using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Libreria2

{
    public class Class1
    {
        public static bool Verificanumeri(double n)
        {
            int n1 = (int)n;
            if (n == n1) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int Arrotondamento(double n)
        {

            int n1 = (int)(n + 0.5);
            return n1;
        }
        public static bool Pari_Dispari(int n1)
        {
            if (n1 % 2==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}   
