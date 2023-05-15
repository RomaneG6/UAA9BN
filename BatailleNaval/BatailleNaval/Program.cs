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
            string[,] bJ1grille2D = new string[11, 11];
            string[,] bJ2grille2D = new string[11, 11];
            string[] alpha;
            string[] porteA = new string[5];
            string[] croisseur = new string[4];
            string[] contreC = new string[3];
            string[] sousM = new string[3];
            string[] torpilleur = new string[2];
            string reponse = "";
            string[] bateau = new string[] { "porte avion (5 cases)", "croiseur (4 cases)", "contre-croiseur (3 cases)", "sous-marin (3 cases)", "torpilleur (2 cases)" };
            int premColonne;
            int premLigne;
            int dernColonne;
            int dernLigne;
            int Ncases = 0; //Permet de placer les bateaux par taille décroissante
            int[] tAleat = new int[11];

            Console.WriteLine("Souhaitez-vous jouer à deux ou tout seul ? Tapez deux ou seul");
            reponse = Console.ReadLine();

            if (reponse == "seul")
            {
                Console.Clear();
                tools.AfficherGrille(bJgrille2D, out alpha, out resultat);//grille du joueur où il essaiera de deviner les bateau de l'adversaire
                tools.ConcatGrille(bJgrille2D, out resultat);
                Console.WriteLine(resultat);
                Console.WriteLine("Placer les différents bateau à votre disposition :\n\n");
                Console.WriteLine("Ecrivez d'abord les extémités de la où vous voulez mettre vos bateau\nEn commmencant par les premières extrémités puis les dernières\n");
                Console.WriteLine("répondre en chiffre \nA -> 1\nB -> 2\nC -> 3\nD -> 4\nE -> 5\nF -> 6\nG -> 7\nH -> 8\nI -> 9\nJ -> 10\n");

                for (int compteur = 0; compteur < bateau.Length; compteur++)
                {
                    Console.WriteLine("Placez le " + bateau[compteur] + "\n");

                    Console.WriteLine("Premières coordonnées :\n");
                    Console.WriteLine("Choisissez la ligne où vous voulez placer votre bateau :");

                    string premCL;
                    do
                    {
                        premCL = Console.ReadLine();
                        Console.WriteLine("Écris un nombre entier");

                    } while (!int.TryParse(premCL, out premLigne));

                    Console.WriteLine("mtn La colonne :");

                    string premCC;
                    do
                    {
                        premCC = Console.ReadLine();
                        Console.WriteLine("Écris un nombre entier");

                    } while (!int.TryParse(premCC, out premColonne));

                    Console.WriteLine("Dernières coordonnées :\n");
                    Console.WriteLine("Choisissez la ligne où vous voulez placer votre bateau :");

                    string dernCL;
                    do
                    {
                        dernCL = Console.ReadLine();
                        Console.WriteLine("Écris un nombre entier");

                    } while (!int.TryParse(dernCL, out dernLigne));

                    Console.WriteLine("La colonne :");
                    string dernCC;
                    do
                    {
                        dernCC = Console.ReadLine();
                        Console.WriteLine("Écris un nombre entier");

                    } while (!int.TryParse(dernCC, out dernColonne));
                    tools.AfficherBateau(premLigne, premColonne, dernLigne, dernColonne, ref bJgrille2D, out resultat, Ncases);
                    Ncases++;
                    tools.ConcatGrille(bJgrille2D, out resultat);
                    Console.WriteLine(resultat);
                }
                tools.ConcatGrille(bJ1grille2D, out resultat);
                Console.WriteLine(resultat);
            }
            else if (reponse == "deux")
            {
                Console.Clear();
                tools.AfficherGrille(bJ1grille2D, out alpha, out resultat);//grille du joueur où il essaiera de deviner les bateau de l'adversaire
                tools.ConcatGrille(bJ1grille2D, out resultat);
                Console.WriteLine(resultat);
                Console.WriteLine("Placer les différents bateau à votre disposition :\n\n");
                Console.WriteLine("Ecrivez d'abord les extémités de la où vous voulez mettre vos bateau\nEn commmencant par les premières extrémités puis les dernières\n");
                Console.WriteLine("répondre en chiffre \nA -> 1\nB -> 2\nC -> 3\nD -> 4\nE -> 5\nF -> 6\nG -> 7\nH -> 8\nI -> 9\nJ -> 10\n");

                for (int compteur = 0; compteur < bateau.Length; compteur++)
                {
                    Console.WriteLine("Placez le " + bateau[compteur] + "\n");

                    Console.WriteLine("Premières coordonnées :\n");
                    Console.WriteLine("Choisissez la ligne où vous voulez placer votre bateau :");

                    string premCL;
                    do
                    {
                        Console.WriteLine("Ecris un nombre entier");
                        premCL = Console.ReadLine();

                    } while (!int.TryParse(premCL, out premLigne));

                    Console.WriteLine("mtn La colonne :");

                    string premCC;
                    do
                    {
                        Console.WriteLine("Ecris un entier, T con");
                        premCC = Console.ReadLine();

                    } while (!int.TryParse(premCC, out premColonne));

                    Console.WriteLine("Dernières coordonnées :\n");
                    Console.WriteLine("Choisissez la ligne où vous voulez placer votre bateau :");

                    string dernCL;
                    do
                    {
                        Console.WriteLine("Ecris un entier, tu peux pas être plus con...");
                        dernCL = Console.ReadLine();

                    } while (!int.TryParse(dernCL, out dernLigne));

                    Console.WriteLine("La colonne :");

                    string dernCC;
                    do
                    {
                        Console.WriteLine("Ecris un entier, tu es un danger pour la société...");
                        Console.WriteLine("\n\n\nRetourne à l'hopital");

                        dernCC = Console.ReadLine();

                    } while (!int.TryParse(dernCC, out dernColonne));
                    tools.AfficherBateau(premLigne, premColonne, dernLigne, dernColonne, ref bJ1grille2D, out resultat, Ncases);
                    Ncases++;
                    tools.ConcatGrille(bJ1grille2D, out resultat);
                    Console.WriteLine(resultat);
                }

                Console.Clear();
                Console.WriteLine("mtn c'est au tour du joueur 2");
                tools.AfficherGrille(bJ2grille2D, out alpha, out resultat);//grille du joueur où il essaiera de deviner les bateau de l'adversaire
                tools.ConcatGrille(bJ2grille2D, out resultat);
                Console.WriteLine(resultat);
                Console.WriteLine("Placer les différents bateau à votre disposition :\n\n");
                Console.WriteLine("Ecrivez d'abord les extémités de la où vous voulez mettre vos bateau\nEn commmencant par les premières extrémités puis les dernières\n");
                Console.WriteLine("répondre en chiffre \nA -> 1\nB -> 2\nC -> 3\nD -> 4\nE -> 5\nF -> 6\nG -> 7\nH -> 8\nI -> 9\nJ -> 10\n");

                for (int compteur = 0; compteur < bateau.Length; compteur++)
                {
                    Console.WriteLine("Placez le " + bateau[compteur] + "\n");

                    Console.WriteLine("Premières coordonnées :\n");
                    Console.WriteLine("Choisissez la ligne où vous voulez placer votre bateau :");

                    string premCL;
                    do
                    {
                        Console.WriteLine("Ecris un nombre entier");
                        premCL = Console.ReadLine();

                    } while (!int.TryParse(premCL, out premLigne));

                    Console.WriteLine("mtn La colonne :");

                    string premCC;
                    do
                    {
                        Console.WriteLine("Ecris un entier, T con");
                        premCC = Console.ReadLine();

                    } while (!int.TryParse(premCC, out premColonne));

                    Console.WriteLine("Dernières coordonnées :\n");
                    Console.WriteLine("Choisissez la ligne où vous voulez placer votre bateau :");

                    string dernCL;
                    do
                    {
                        Console.WriteLine("Ecris un entier, tu peux pas être plus con...");
                        dernCL = Console.ReadLine();

                    } while (!int.TryParse(dernCL, out dernLigne));

                    Console.WriteLine("La colonne :");
                    dernColonne = int.Parse(Console.ReadLine());
                    string dernCC;
                    do
                    {
                        Console.WriteLine("Ecris un entier, tu es un danger pour la société...");
                        Console.WriteLine("\n\n\nRetourne à l'hopital");

                        dernCC = Console.ReadLine();

                    } while (!int.TryParse(dernCC, out dernLigne));
                    tools.AfficherBateau(premLigne, premColonne, dernLigne, dernColonne, ref bJ2grille2D, out resultat, Ncases);
                    Ncases++;
                    tools.ConcatGrille(bJ2grille2D, out resultat);
                    Console.WriteLine(resultat);
                }
                Console.Clear();

                tools.ConcatGrille(bJ1grille2D, out resultat);
                Console.WriteLine(resultat);
            }
            else
            {
                Console.WriteLine("Tu sais pas lire ou quoi? J'ai dis seul ou à deux !");
                Console.ReadLine();
            }
        }
    }
}
