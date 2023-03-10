using System;
using System.Collections.Generic;
using System.Text;

namespace BatailleNaval
{
    internal class Outils
    {
        public void AfficherGrille(string[,] tab2D, out string[] alpha, out string resultat)
        {
            alpha = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            resultat = "";
            int nbr = 0;
            for (int l = 0; l <= tab2D.GetLength(0) - 1; l++)
            {
                for (int c = 0; c <= tab2D.GetLength(1) - 1; c++)
                {
                    tab2D[c, l] = "0";
                    tab2D[c, 0] = nbr.ToString();
                    nbr++;

                    for (int n = 0; n < alpha.Length; n++)
                    {
                        tab2D[0, l] = alpha[n];
                    }
                    resultat = resultat + tab2D[c, l] + " " + " " + " " + " " + " ";
                }
                resultat = resultat + "\n" + "\n";
            }
        }
        public void AfficherGrilleETBateau(int premBordColonne, string premBordLigne, int dernBordColonne, string dernBordLigne, string[] bateau, string[,] BJgrille2D, string resultat)
        {
            for (int l = 0; l < BJgrille2D.GetLength(0); l++)
            {
                for (int c = 0; c < BJgrille2D.GetLength(1); c++)
                {   
                    if (premBordColonne == c)
                    {
                        premBordColonne = 1;
                    }
                }
            }
            resultat = resultat + premBordColonne;
        }
    }
}
