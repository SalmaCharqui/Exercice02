using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02
{
    internal class Program
    {
        void InsererNbr(int nombre, int[] tab)
        {
            int N = tab.Length;
            int i = 0;
            while (nombre >= tab[i] && i < N-1)
            {
                i++;
            }
            if (i >= N - 1)
            {
                tab[i-1] = nombre;
            }
            else
            {
                for(int j = N-1; j > i; j--)
                {
                    tab[j]=tab[j-1];
                }
                tab[i] = nombre;
                N++;
            }
           
            Console.WriteLine("affichage apres insertion:");
            
            for(int k = 0; k <= N; k++)
            {
                Console.WriteLine(tab[k]);

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("le tableau avant insertion:");
            int[] tab = new int[]{ 10, 25, 30, 40, 55, 60} ;
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
            Console.WriteLine("veuillez saisir le nombre a inserer:");
            String nbr=Console.ReadLine();
            int nombre = int.Parse(nbr);
            Program p= new Program();
            p.InsererNbr(nombre,tab);
            Console.ReadLine();
        }
    }
}
