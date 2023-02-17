using System;
using System.Collections.Generic;
using System.Text;

namespace BatailleNaval
{
    internal class Outils
    {
        public void AfficherGrille(string[,] grille2D, out string[] alpha, out string resultat)
        {
            alpha = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            resultat = "";
            int nbr = 0;
            for (int l = 0; l <= grille2D.GetLength(0) - 1; l++)
            {
                for (int c = 0; c <= grille2D.GetLength(1) - 1; c++)
                {
                    grille2D[c, l] = "0";
                    grille2D[c, 0] = nbr.ToString();
                    nbr++;
                    for (int n = 0; n < alpha.Length; n++)
                    {
                        grille2D[0, l] = alpha[n];
                        grille2D[0, 0] = "0";
                    }

                    resultat = resultat + grille2D[c, l] + " ";
                }
                resultat = resultat + "\n";
            }
        }
    }
}
