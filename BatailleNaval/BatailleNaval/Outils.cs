﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BatailleNaval
{
    internal class Outils
    {
        /// <summary>
        /// tab2D[11,11], resultat est vide
        /// Créer une matrice dont la première ligne affiche des nombre et dont la première colonne affiche des lettres
        /// </summary>
        /// <param name="tab2D">grille vide composé de 11 ligne dont une remplie pour mettre les coordonnées en int et de 11 colonnes dont une remplie pour mettre les coordonnées du tableau alpha</param>
        /// <param name="alpha">tableau qui contient une partie des lettres de l’alphabet</param>
        /// <param name="resultat">l’affichage du tableau</param>
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
        /// <summary>
        /// resultat est vide
        /// Permet a l’utilisateur d’encoder les coordonnées de ses bateaux
        /// </summary>
        /// <param name="bateau">tableau qui contient tous les bateaux</param>
        /// <param name="premLigne">première coordonnée ligne donnée par le joueur </param>
        /// <param name="premColonne">première coordonnée Colonne donnée par le joueur </param>
        /// <param name="dernLigne">dernière coordonnée ligne donnée par le joueur </param>
        /// <param name="dernColonne">dernière coordonnée Colonne donnée par le joueur </param>
        /// <param name="Ncases">compteur du tableau bateau</param>
        /// <param name="resultat">résultat qui affiche les coordonnées encodée</param>
        /// <param name="tab2D">grille du jeux ou on affiche les tableau</param>
        ///
        public void Encodage(string[] bateau, ref int premLigne, ref int premColonne, ref int dernLigne, ref int dernColonne, int Ncases, out string resultat, ref string[,] tab2D, out int listPL, out int listPC, out int listDL, out int listDC)
        {
            bool erreur = true;
            string array;
            listPL = 0;
            listPC = 0;
            listDL = 0;
            listDC = 0;
            resultat = "";
            string question;
            for (int compteur = 0; compteur < bateau.Length; compteur++)
            {
                while (erreur == true)
                {
                    Console.WriteLine("Placez le " + bateau[compteur] + "\n");

                    Console.WriteLine("Premières coordonnées :\n");
                    question = "Choisissez la ligne où vous voulez placer votre bateau :";

                    TryParse(question, out premLigne);
                    listPL = listPL + premLigne;
                    array = listPL + ",";
                    Console.WriteLine(array);

                    question = "mtn La colonne :";

                    TryParse(question, out premColonne);
                    listPC = listPC + premLigne;
                    array = listPC + ",";
                    Console.WriteLine(array);

                    Console.WriteLine("Dernières coordonnées :\n");
                    question = "Choisissez la ligne où vous voulez placer votre bateau :";

                    TryParse(question, out dernLigne);
                    listDL = listDL + premLigne;
                    array = listDL + ",";
                    Console.WriteLine(array);

                    question = "La colonne :";

                    TryParse(question, out dernColonne);
                    listDC = listDC + premLigne;
                    array = listDC + ",";
                    Console.WriteLine(array);
                    if (compteur == 1)
                    {
                        if (premLigne == dernLigne - 5 || premColonne == dernColonne - 5)
                        {
                            erreur = false;
                        }
                        else
                        {
                            erreur = true;
                        }
                    }
                    else if (compteur == 1)
                    {
                        if (premLigne == dernLigne + 5 || premColonne == dernColonne + 5)
                        {
                            erreur = false;
                        }
                        else
                        {
                            erreur = true;
                        }
                    }
                    else if (compteur == 2)
                    {
                        if (premLigne == dernLigne - 4 || premColonne == dernColonne - 4)
                        {
                            erreur = false;
                        }
                        else
                        {
                            erreur = true;
                        }
                    }
                    else if (compteur == 2)
                    {
                        if (premLigne == dernLigne + 4 || premColonne == dernColonne + 4)
                        {
                            erreur = false;
                        }
                        else
                        {
                            erreur = true;
                        }
                    }
                    else if (compteur == 3)
                    {
                        if (premLigne == dernLigne - 3 || premColonne == dernColonne - 3)
                        {
                            erreur = false;
                        }
                        else
                        {
                            erreur = true;
                        }
                    }
                    else if (compteur == 3)
                    {
                        if (premLigne == dernLigne + 3 || premColonne == dernColonne + 3)
                        {
                            erreur = false;
                        }
                        else
                        {
                            erreur = true;
                        }
                    }
                    else if (compteur == 4)
                    {
                        if (premLigne == dernLigne - 3 || premColonne == dernColonne - 3)
                        {
                            erreur = false;
                        }
                        else
                        {
                            erreur = true;
                        }
                    }
                    else if (compteur == 4)
                    {
                        if (premLigne == dernLigne + 3 || premColonne == dernColonne + 3)
                        {
                            erreur = false;
                        }
                        else
                        {
                            erreur = true;
                        }
                    }
                    else if (compteur == 5)
                    {
                        if (premLigne == dernLigne - 2 || premColonne == dernColonne - 2)
                        {
                            erreur = false;
                        }
                        else
                        {
                            erreur = true;
                        }
                    }
                    else if (compteur == 5)
                    {
                        if (premLigne == dernLigne + 2 || premColonne == dernColonne + 2)
                        {
                            erreur = false;
                        }
                        else
                        {
                            erreur = true;
                        }
                    }
                }
               
                AfficherBateau(premLigne, premColonne, dernLigne, dernColonne, ref tab2D, out resultat, Ncases);
                Ncases++;
                ConcatGrille(tab2D, ref resultat);
                Console.WriteLine(resultat);
            }
        }
        /// <summary>
        /// tab2D[11,11], resultat est vide
        /// Placer les bateaux dans la matrice
        /// </summary>
        /// <param name="premLigne">première extrémité ligne du bateau</param>
        /// <param name="premColonne">première extrémité colonne du bateau</param>
        /// <param name="dernLigne">dernière extrémité ligne du bateau</param>
        /// <param name="dernColonne">dernière extrémité colonne du bateau</param>
        /// <param name="tab2D">grille vide qui va être remplie par les bateau</param>
        /// <param name="resultat"></param>
        /// <param name="Ncases"></param>
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
        //public void BatIA(ref int sensBat)
        //{
        //    Random nAleat = new Random();
        //    sensBat = nAleat.Next(1, 3);
        //}
        /// <summary>
        /// tab2D[11,11], resultat est vide
        /// Afficher la matrice et les bateaux
        /// </summary>
        /// <param name="tab2D">grille vide qui va être remplie par les bateau</param>
        /// <param name="resultat">chaine de caractère qui affichera la matrice</param>
        public void ConcatGrille( string[,] tab2D, ref string resultat)//Concatenation de la grille avec les bateau
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
        /// <summary>
        /// question est non vide
        /// permet quand le joueur ne répond pas correctement de ne pas faire crash le jeu 
        /// </summary>
        /// <param name="question">Question donnée au joueur</param>
        /// <param name="n">Réponse  du joueur à la question en chiffre </param>
        public void TryParse(string question, out int n)
        {
            string nUser;
            Console.WriteLine(question);
            nUser = Console.ReadLine();
            while (!int.TryParse(nUser, out n))
            {
                Console.WriteLine("Écris un nombre entier");
            }
        }
        /// <summary>
        /// resultat est vide
        /// permet quand le joueur choisit une coordonnée savoir si elle touche le bateau ou pas
        /// </summary>
        /// <param name="tab2D">grille du jeux ou on affiche les tableau</param>
        /// <param name="c2">Coordonnée colonne pour chercher les bateaux de l’adversaire donnée par le joueur</param>
        /// <param name="l2">Coordonnée ligne pour chercher les bateaux de l’adversaire donnée par le joueur</param>
        /// <param name="premLigne">première coordonnée ligne donnée par le joueur </param>
        /// <param name="premColonne">première coordonnée Colonne donnée par le joueur </param>
        /// <param name="dernLigne">dernière coordonnée ligne donnée par le joueur </param>
        /// <param name="dernColonne">dernière coordonnée Colonne donnée par le joueur </param>
        /// <param name="resultat">résultat qui affiche les coordonnées encodée</param>
        public void Touche(ref string[,] tab2D, int c2, int l2, int listPL, int listPC, int listDL, int listDC, ref string resultat)
        {
            resultat = "";
            int l = l2;
            int c = c2;
            for (int i = 0; i <= 5 - 1; i++)
            {
                if (listPL[i] < listDL[i])
                {
                    if (listPL[i] <= l2 && l2 <= listDL[i])
                    {
                        tab2D[l, c] = "O";
                        resultat += tab2D[l, c2];
                        Console.WriteLine("Touché");
                    }
                    else
                    {
                        tab2D[l, c] = "X";
                        resultat += tab2D[l, c];
                        Console.WriteLine("Raté");
                    }
                }
                else if (listPL[i] > listDL[i])
                {
                    if (listPL[i] >= l2 && l2 >= listDL[i])
                    {
                        tab2D[l, c] = "O";
                        resultat += tab2D[l, c];
                        Console.WriteLine("Touché");
                    }
                    else
                    {
                        tab2D[l, c] = "X";
                        resultat += tab2D[l, c];
                        Console.WriteLine("Raté");
                    }
                }
                else if (listPC[i] < listDC[i])
                {
                    if (listPC[i] <= c2 && c2 <= listDC[i])
                    {
                        tab2D[l, c] = "O";
                        resultat += tab2D[l, c];
                        Console.WriteLine("Touché");
                    }
                    else
                    {
                        tab2D[l, c] = "X";
                        resultat += tab2D[l, c];
                        Console.WriteLine("Raté");
                    }
                }
                else if (listPC[i] > listDC[i])
                {

                    if (listPC[i] >= c2 && c2 >= listDC[i])
                    {
                        tab2D[l, c] = "O";
                        resultat += tab2D[l, c];
                        Console.WriteLine("Touché");
                    }
                    else
                    {
                        tab2D[l, c] = "X";
                        resultat += tab2D[l, c];
                        Console.WriteLine("Raté");
                    }
                }
            }
        }
    }
}
