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
            
            for (int l = 0; l <= tab2D.GetLength(0) - 1; l++)
            {
                int nbr = 0;
                for (int c = 0; c <= tab2D.GetLength(1) - 1; c++)
                {
                    if (l == 0 && c == 0)
                    {
                        tab2D[l, c] = " ";
                    }
                    else if (l == 0)
                    {
                        tab2D[l, c] = nbr.ToString();
                    }
                    else if (c == 0)
                    {
                        tab2D[l, c] = alpha[l - 1];
                    }
                    else
                    {
                        tab2D[l, c] = "0";
                    }
                    resultat = resultat + tab2D[l, c] + " " + " " + " " + " " + " ";
                    nbr++;
                }
                resultat = resultat + "\n" + "\n";
            }
        }
        public void AfficherGrilleETBateau(int premBordColonne, int premBordLigne, string dernBordColonne, int dernBordLigne, string[] bateau, string[,] BJgrille2D, string resultat)
        {
            for (int l = 0; l < BJgrille2D.GetLength(0); l++)
            {
                for (int c = 0; c < BJgrille2D.GetLength(1); c++)
                {
                    if (premBordLigne == l && premBordColonne == c)
                    {
                        BJgrille2D[l, c] = "1";
                    }
                }
            }
            resultat = resultat + premBordLigne;
        }
    }
}
