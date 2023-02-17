using System;

namespace BatailleNaval
{
    class Program
    {
        static void Main(string[] args)
        {
            string resultat;
            int[,] grille2D = new int[10, 10];
            //char[] alpha = "ABCDEFGHIJ".ToCharArray();
            AfficherGrille(grille2D, out resultat);
            Console.WriteLine(resultat);
        }
        static void AfficherGrille(int[,] grille2D, out string resultat)
        {
            resultat = "";

            for (int i = 0; i < grille2D.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < grille2D.GetLength(1) - 1; j++)
                {
                    grille2D[i, j] = 0;
                    resultat = resultat + grille2D[i, j] + " ";
                }
                resultat = resultat + "\n";
            }
            //int n = 0;
            //int nbr = 1;
            //for (int compteurColonne = 0; compteurColonne < grille2D.GetLength(0) - 1; compteurColonne++)
            //{

            //    grille2D[0, compteurColonne] = Convert.ToChar(nbr);
            //    nbr++;
            //}
            //for (int compteurLigne = 0; compteurLigne < grille2D.GetLength(1) - 1; compteurLigne++)
            //{
            //    grille2D[compteurLigne, 0] = alpha[n] ;
            //    nbr++;
            //    Console.WriteLine();
            //}
        }
    }
}
