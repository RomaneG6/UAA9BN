using System;

namespace BatailleNaval
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grille2D = new int[10, 10];
            char[] alpha = "ABCDEFGHIJ".ToCharArray();
            Console.WriteLine(alpha);
            AfficherGrille(grille2D, alpha);
            Console.WriteLine(grille2D);
        }
        static void AfficherGrille(int[,] grille2D, char[] alpha)
        {
            int nbr = 1;
            for (int compteurColonne = 0; compteurColonne < 10; compteurColonne++)
            {
                grille2D[0, compteurColonne] = nbr;
                nbr++;
            }
            for (int compteurLigne = 0; compteurLigne < 10; compteurLigne++)
            {
                grille2D[compteurLigne, 0] = nbr;
                nbr++;
                Console.WriteLine();
            }
        }
    }
}
