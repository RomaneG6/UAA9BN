using System;

namespace BatailleNaval
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] grille2D = new string[10, 10];
            string[] alpha = "ABCDEFGHIJ".ToCharArray();
            AfficherGrille(grille2D, alpha);
            Console.WriteLine(grille2D);
        }
        static void AfficherGrille(string[,] grille2D, string[] alpha)
        {
            int n = 0;
            int nbr = 1;
            for (int compteurColonne = 0; compteurColonne < 10; compteurColonne++)
            {
                grille2D[0, compteurColonne] = Convert.ToString(nbr);
                nbr++;
            }
            for (int compteurLigne = 0; compteurLigne < 10; compteurLigne++)
            {
                grille2D[compteurLigne, 0] = alpha[n] ;
                nbr++;
                Console.WriteLine();
            }
        }
    }
}
