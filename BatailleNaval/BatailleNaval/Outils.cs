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
        public void AfficherBateau(int premLigne, int premColonne, int dernLigne, int dernColonne, ref string[,] tab2D, out string resultat, int Ncases)
        {
            resultat = "";
            for (int l = premLigne; l <= dernLigne; l++)
            {
                for (int c = premColonne; c <= dernColonne; c++)
                {
                    if (Ncases == 0)
                    {
                        tab2D[l, c] = "5";
                        resultat = resultat + tab2D[l, c];
                    }
                    else if (Ncases == 1)
                    {
                        tab2D[l, c] = "4";
                        resultat = resultat + tab2D[l, c];
                    }
                    else if (Ncases == 2)
                    {
                        tab2D[l, c] = "3";
                        resultat = resultat + tab2D[l, c];
                    }
                    else if (Ncases == 3)
                    {
                        tab2D[l, c] = "2";
                        resultat = resultat + tab2D[l, c];
                    }
                    else if (Ncases == 4)
                    {
                        tab2D[l, c] = "1";
                        resultat = resultat + tab2D[l, c];
                    } 
                }  
            }
        }
        public void BatIA(int[] tAleat, out int nDimBat)
        {
            int i;
            Random nAleat = new Random();
            for (i = 1; i <= 11 - 1; i++)
            {
                tAleat[i] = nAleat.Next(1, 10);
            }
            nDimBat = nAleat;
        }
        public void SensBatIA(string[] sensBat, out string choiSens)
        {
            int i;
            Random choix = new Random();
            for (i = 0; i <= 2 - 1; i++)
            {
                sensBat[i] = choix.Next(0, 1);
            }
            choiSens = sensBat[i];
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
