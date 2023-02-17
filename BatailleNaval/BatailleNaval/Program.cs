using System;

namespace BatailleNaval
{
    class Program
    {
        static void Main(string[] args)
        {
            Outils tools = new Outils();
            string resultat;
            string[,] grille2D = new string[11, 11];
            string[] alpha;
            tools.AfficherGrille(grille2D,out alpha, out resultat);
            Console.WriteLine(resultat);
            Console.WriteLine(resultat);
       
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
