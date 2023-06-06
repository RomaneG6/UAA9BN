using System;
using System.Collections.Generic;

namespace BatailleNaval
{
    class Program
    {
        static void Main(string[] args)
        {
            Outils tools = new Outils();
            string resultat;
            string resultat1;
            string resultat2;
            string resultat1A = "";
            string resultat2A = "";

            string[,] bJgrille2D = new string[11, 11];
            string[,] bJ1grille2D = new string[11, 11];
            string[,] bJ2grille2D = new string[11, 11];

            string[,] videGrille1 = new string[11, 11];
            string[,] videGrille2 = new string[11, 11];

            string[] alpha;
            string[] porteA = new string[5];
            string[] croisseur = new string[4];
            string[] contreC = new string[3];
            string[] sousM = new string[3];
            string[] torpilleur = new string[2];
            string reponse = "";
            string recom = "oui";
            string[] bateau = new string[] { "porte avion (5 cases)", "croiseur (4 cases)", "contre-croiseur (3 cases)", "sous-marin (3 cases)", "torpilleur (2 cases)" };
            string question;
            int n;
            int premColonne = 0;
            int premLigne = 0;
            int dernColonne = 0;
            int dernLigne = 0;

            int premColonne1 = 0;
            int premLigne1 = 0;
            int dernColonne1 = 0;
            int dernLigne1 = 0;

            int premColonne2 = 0;
            int premLigne2 = 0;
            int dernColonne2 = 0;
            int dernLigne2 = 0;

            int[] listPL;
            int[] listPC;
            int[] listDL;
            int[] listDC;

            int[] listPL1;
            int[] listPC1;
            int[] listDL1;
            int[] listDC1;

            int[] listPL2;
            int[] listPC2;
            int[] listDL2;
            int[] listDC2;

            int c2;// c'est le joueur 1 qui tape les coordonnées mais ce sont celles du joueur 2
            int l2;

            int c1;
            int l1;

            int n1 = 0;
            int n2 = 0;
            int Ncases = 0; //Permet de placer les bateaux par taille décroissante
            int Ncases1 = 0;
            int Ncases2 = 0;

            Console.WriteLine("Souhaitez-vous jouer à deux ? Tapez deux");
            reponse = Console.ReadLine();

            //if (reponse == "seul")
            //{

            //    Console.Clear();
            //    tools.AfficherGrille(bJgrille2D, out alpha, out resultat);
            //    tools.ConcatGrille(bJgrille2D, ref resultat);
            //    Console.WriteLine(resultat);
            //    Console.WriteLine("Placer les différents bateau à votre disposition :\n\n");
            //    Console.WriteLine("Ecrivez d'abord les extémités de la où vous voulez mettre vos bateau\nEn commmencant par les premières extrémités puis les dernières\n");
            //    Console.WriteLine("répondre en chiffre \nA -> 1\nB -> 2\nC -> 3\nD -> 4\nE -> 5\nF -> 6\nG -> 7\nH -> 8\nI -> 9\nJ -> 10\n");

            //    tools.Encodage(bateau, ref premLigne, ref premColonne, ref dernLigne, ref dernColonne, Ncases, out resultat, ref bJgrille2D);
            //    tools.ConcatGrille(bJgrille2D, ref resultat);
            //    Console.WriteLine(resultat);
            //}
            while (recom == "oui")
            {
                if (reponse == "deux")
                {
                    Console.Clear();

                    Console.WriteLine("Joueur 1 vous pouvez encoder vos bateau :");
                    tools.AfficherGrille(bJ1grille2D, out alpha, out resultat1);
                    tools.ConcatGrille(bJ1grille2D, ref resultat1);
                    Console.WriteLine(resultat1);
                    Console.WriteLine("Placer les différents bateau à votre disposition :\n\n");
                    Console.WriteLine("Ecrivez d'abord les extémités de la où vous voulez mettre vos bateau\nEn commmencant par les premières extrémités puis les dernières\n");
                    Console.WriteLine("répondre en chiffre \nA -> 1\nB -> 2\nC -> 3\nD -> 4\nE -> 5\nF -> 6\nG -> 7\nH -> 8\nI -> 9\nJ -> 10\n");
                    tools.Encodage(bateau, ref premLigne1, ref premColonne1, ref dernLigne1, ref dernColonne1, Ncases1, out resultat1, ref bJ1grille2D, out listPL1, out listPC1, out listDL1, out listDC1);


                    Console.WriteLine("mtn c'est au tour du Joueur 2");
                    tools.AfficherGrille(bJ2grille2D, out alpha, out resultat2);
                    tools.ConcatGrille(bJ2grille2D, ref resultat2);
                    Console.WriteLine(resultat2);
                    tools.Encodage(bateau, ref premLigne2, ref premColonne2, ref dernLigne2, ref dernColonne2, Ncases2, out resultat2, ref bJ2grille2D, out listPL2, out listPC2, out listDL2, out listDC2);

                    while (n1 != 5 || n2 != 5)
                    {
                        tools.AfficherGrille(videGrille1, out alpha, out resultat1A);//grille du joueur où il essaiera de deviner les bateau de l'adversaire
                        tools.ConcatGrille(videGrille1, ref resultat1A);
                        Console.WriteLine(resultat1A);
                        Console.WriteLine("Joueur 1 essayez de diviner les positions des bateaus de l'adversaire");
                        question = "ligne :";
                        tools.TryParse(question, out l2);

                        question = "Colonne :";
                        tools.TryParse(question, out c2);
                        tools.Touche(ref videGrille1, c2, l2, listPL2, listPC2, listDL2, listDC2, ref resultat1A);
                        if (videGrille1[l2, c2] == "O")
                        {
                            if (videGrille1[premLigne2, dernLigne2] == "O" && videGrille1[premColonne2, dernColonne2] == "O")
                            {
                                Console.WriteLine("GG! Vous avez trouvé un bateau de " + (dernLigne2 - premLigne2) + (dernColonne2 - premColonne2));
                                n1++;
                            }
                        }

                        tools.ConcatGrille(videGrille1, ref resultat1A);
                        Console.WriteLine(resultat2A);

                        tools.AfficherGrille(videGrille2, out alpha, out resultat2A);//grille du joueur où il essaiera de deviner les bateau de l'adversaire
                        tools.ConcatGrille(videGrille2, ref resultat2A);
                        Console.WriteLine(resultat2A);
                        Console.WriteLine("Joueur 2 essayez de diviner les positions des bateaus de l'adversaire");
                        question = "ligne :";
                        tools.TryParse(question, out l1);

                        question = "Colonne :";
                        tools.TryParse(question, out c1);
                        tools.Touche(ref videGrille2, c1, l1, listPL1, listPC1, listDL1, listDC1, ref resultat2A);

                        if (videGrille2[l2, c2] == "O")
                        {
                            if (videGrille2[premLigne1, dernLigne1] == "O" && videGrille1[premColonne1, dernColonne1] == "O")
                            {
                                Console.WriteLine("GG! Vous avez trouvé un bateau de " + (dernLigne1 - premLigne1) + (dernColonne1 - premColonne1));
                                n2++;
                            }
                        }
                    }
                    if (n1 == 5)
                    {
                        Console.WriteLine("Félicitation joueur 1 !!!!");
                    }
                    else if (n2 == 5)
                    {
                        Console.WriteLine("Félicitation joueur 2 !!!!");
                    }
                    Console.WriteLine("Voulez-vous rejouer ?tapez oui/non");
                    recom = Console.ReadLine();
                    if (recom != "oui")
                    {
                        Console.WriteLine("Merci!! d'avoir jouer :)");                    
                    }
                }
                else
                {
                    Console.WriteLine("Tu sais pas lire ou quoi? J'ai dis seul ou à deux !");
                    Console.ReadLine();
                }
            }
        }
    }
}
