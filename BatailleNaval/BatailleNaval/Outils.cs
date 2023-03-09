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
                    //for (int n = 0; n < 10; n++)
                    //{
                        //tab2D[0, l] = alpha[n];
                        tab2D[0, 1] = alpha[0];
                        tab2D[0, 2] = alpha[1];
                        tab2D[0, 3] = alpha[2];
                        tab2D[0, 4] = alpha[3];
                        tab2D[0, 5] = alpha[4];
                        tab2D[0, 6] = alpha[5];
                        tab2D[0, 7] = alpha[6];
                        tab2D[0, 8] = alpha[7];
                        tab2D[0, 9] = alpha[8];
                        tab2D[0, 10] = alpha[9];
                    //}
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
