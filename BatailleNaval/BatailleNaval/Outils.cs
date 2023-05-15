using System;
using System.Collections.Generic;
using System.Text;

namespace BatailleNaval
{
    internal class Outils
    {
        public void AfficherGrille(string[,] tab2D, out string[] alpha, out string resultat)//Création de la grille
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
        public void AfficherBateau(int premLigne, int premColonne, int dernLigne, int dernColonne, ref string[,] tab2D, out string resultat, int Ncases)//placer les bateau dans la grille
        {
            resultat = "";
            for (int l = premLigne; l <= dernLigne; l++)
            {
                for (int c = premColonne; c <= dernColonne; c++)
                {
                    if (Ncases == 0)
                    {
                        tab2D[l, c] = "5";//porte avion
                        resultat += tab2D[l, c];
                    }
                    else if (Ncases == 1)
                    {
                        tab2D[l, c] = "4";//croiseur
                        resultat += tab2D[l, c];
                    }
                    else if (Ncases == 2)
                    {
                        tab2D[l, c] = "3";//contre-croiseur
                        resultat += tab2D[l, c];
                    }
                    else if (Ncases == 3)
                    {
                        tab2D[l, c] = "2";//sous - marin
                        resultat += tab2D[l, c];
                    }
                    else if (Ncases == 4)
                    {
                        tab2D[l, c] = "1";//torpilleur
                        resultat += tab2D[l, c];
                    } 
                }  
            }
        }
        public void BatIA(ref int sensBat)
        {
            Random nAleat = new Random();
            sensBat = nAleat.Next(1, 3);
        }
        public void ConcatGrille( string[,] tab2D, out string resultat)//Concatenation de la grille avec les bateau
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
