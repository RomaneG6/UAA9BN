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
                        tab2D[l, c] = "-";
                    } 
                    nbr++;
                }
            }
        }
        public void AfficherBateau(int premLigne, int premColonne, int dernLigne, int dernColonne, ref string[,] tab2D, string[] bateau)
        {
            int compteur = 0;
            for (int l = premLigne; l <= dernLigne; l++)
            {
                for (int c = premColonne; c <= dernColonne; c++)
                {
                    if (bateau[compteur] == "porte avion (5 cases)")
                    {
                        tab2D[l, c] = "5";
                    }

                    else if (bateau[compteur] == "croiseur (4 cases)")
                    {
                        tab2D[l, c] = "4";
                    }
                    else if (bateau[compteur] == "contre-croiseur (3 cases)")
                    {
                        tab2D[l, c] = "3";
                    }
                    else if (bateau[compteur] == "sous-marin (3 cases)")
                    {
                        tab2D[l, c] = "2";
                    }
                    else if (bateau[compteur] == "torpilleur (2 cases)")
                    {
                        tab2D[l, c] = "1";
                    }
                }
            }
        }
        public void ConcatGrille( string[,] tab2D, out string resultat)
        {
            resultat = "";
            for (int l = 0; l <= tab2D.GetLength(0) - 1; l++)
            {
                for (int c = 0; c <= tab2D.GetLength(1) - 1; c++)
                {
                    resultat = resultat + tab2D[l, c] + "     ";
                }
                resultat = resultat + "\n\n";
            }
        }
    }
}
