using System;

namespace BatailleNaval
{
    class Program
    {
        static void Main(string[] args)
        {
            Outils tools = new Outils();
            string resultat;
            string[,] bJgrille2D = new string[11, 11];
            string[,] Jgrille2D = new string[11, 11];
            string[] alpha;
            string[] porteA = new string[5];
            string[] croisseur = new string[4];
            string[] contreC = new string[3];
            string[] sousM = new string[3];
            string[] torpilleur = new string[2];
            string reponse = "";
            string[] bateau = new string[] { "porte avion (5 cases)", "croiseur (4 cases)", "contre-croiseur (3 cases)", "sous-marin (3 cases)", "torpilleur (2 cases)" };
            string[] sensBat = new string[] { "horizontal", "vertical" };
            int premColonne;
            int premLigne;
            int dernColonne;
            int dernLigne;
            int Ncases = 0;
            int[] tAleat = new int[11];
            int nDimBat;
            int pLNDimBat;
            int pCNDimBat;
            int dLNDimBat;
            int dCNDimBat;
            int compteurCaseA = 6;
            int compteurCaseD = 5;

            Console.WriteLine("Souhaitez-vous jouer à deux ou tout seul ? Tapez deux ou seul");
            reponse = Console.ReadLine();
            Console.WriteLine("\n");
            if (reponse == "seul")
            {
                tools.AfficherGrille(bJgrille2D, out alpha, out resultat);//grille du joueur où il essaiera de deviner les bateau de l'adversaire
                tools.ConcatGrille(bJgrille2D, out resultat);
                Console.WriteLine(resultat);
                Console.WriteLine("Placer les différents bateau à votre disposition :\n\n");
                Console.WriteLine("Ecrivez d'abord les extémités de la où vous voulez mettre vos bateau\nEn commmencant par les premières extrémités puis les dernières\n");

                for (int compteur = 0; compteur < bateau.Length; compteur++)
                {
                    Console.WriteLine("Placez le " + bateau[compteur] + "\n");

                    Console.WriteLine("Premières coordonnées :\n");
                    Console.WriteLine("En sachant qu'il faut répondre en chiffre \nA -> 1\nB -> 2\nC -> 3\nD -> 4\nE -> 5\nF -> 6\nG -> 7\nH -> 8\nI -> 9\nJ -> 10\nChoisissez la ligne où vous voulez placer votre bateau :");
                    premLigne = int.Parse(Console.ReadLine());
                    Console.WriteLine("La colonne :");
                    premColonne = int.Parse(Console.ReadLine());

                    Console.WriteLine("Dernières coordonnées :\n");
                    Console.WriteLine("En sachant qu'il faut répondre en chiffre \nA -> 1\nB -> 2\nC -> 3\nD -> 4\nE -> 5\nF -> 6\nG -> 7\nH -> 8\nI -> 9\nJ -> 10\nChoisissez la ligne où vous voulez placer votre bateau :");
                    dernLigne = int.Parse(Console.ReadLine());
                    Console.WriteLine("La colonne :");
                    dernColonne = int.Parse(Console.ReadLine());
                    tools.AfficherBateau(premLigne, premColonne, dernLigne, dernColonne, ref bJgrille2D,out resultat, Ncases);
                    Ncases++;
                    tools.ConcatGrille(bJgrille2D, out resultat);
                    Console.WriteLine(resultat);
                }
                for (int compteur = 0; compteur < bateau.Length; compteur++)
                {
                    Console.WriteLine("Placez le " + bateau[compteur] + "\n");

                    Console.WriteLine("Premières coordonnées :\n");
                    Console.WriteLine("En sachant qu'il faut répondre en chiffre \nA -> 1\nB -> 2\nC -> 3\nD -> 4\nE -> 5\nF -> 6\nG -> 7\nH -> 8\nI -> 9\nJ -> 10\nChoisissez la ligne où vous voulez placer votre bateau :");
                    tools.BatIA(tAleat, out pLNDimBat);
                    pLNDimBat = int.Parse(Console.ReadLine());
                    Console.WriteLine("La colonne :");
                    tools.BatIA(tAleat, out pCNDimBat);
                    pCNDimBat = int.Parse(Console.ReadLine());

                    Console.WriteLine("Dernières coordonnées :\n");
                    Console.WriteLine("En sachant qu'il faut répondre en chiffre \nA -> 1\nB -> 2\nC -> 3\nD -> 4\nE -> 5\nF -> 6\nG -> 7\nH -> 8\nI -> 9\nJ -> 10\nChoisissez la ligne où vous voulez placer votre bateau :");
                    tools.BatIA(tAleat, out nDimBat);
                    if (pLNDimBat <= compteurCaseA)
                    {
                        dLNDimBat = nDimBat + compteurCaseD;
                    }
                    else if (pLNDimBat >= compteurCaseD)
                    {
                        dLNDimBat = nDimBat - compteurCaseD;
                    }
                    dLNDimBat = int.Parse(Console.ReadLine());
                    compteurCaseA++;
                    compteurCaseD--;

                    if (bateau[compteur] == "contre-croiseur (3 cases)" || bateau[compteur] == "sous-marin (3 cases)")
                    {
                        if (pLNDimBat <= 8)
                        {
                            dLNDimBat = nDimBat + 3;
                        }
                        else if (pLNDimBat >= 3)
                        {
                            dLNDimBat = nDimBat - 3;
                        }
                        dLNDimBat = int.Parse(Console.ReadLine());
                    }

                    dernLigne = int.Parse(Console.ReadLine());
                    Console.WriteLine("La colonne :");
                    dCNDimBat = int.Parse(Console.ReadLine());
                    tools.AfficherBateau(pLNDimBat, pCNDimBat, dLNDimBat, dCNDimBat, ref bJgrille2D, out resultat, Ncases);
                    Ncases++;
                    tools.ConcatGrille(bJgrille2D, out resultat);
                    Console.WriteLine(resultat);
                }
            }
        }
    }
}
