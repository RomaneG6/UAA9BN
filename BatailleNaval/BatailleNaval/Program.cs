using System;

namespace BatailleNaval
{
    class Program
    {
        static void Main(string[] args)
        {
            Outils tools = new Outils();
            string resultat;
            string[,] BJgrille2D = new string[11, 11];
            string[,] Jgrille2D = new string[11, 11];
            string[] alpha;
            string[] porteA = new string[5];
            string[] croisseur = new string[4];
            string[] contreC = new string[3];
            string[] sousM = new string[3];
            string[] torpilleur = new string[2];
            string reponse = "";
            string[] bateau = new string[] { "porte avion (5 cases)", "croiseur (4 cases)", "contre-croiseur (3 cases)", "sous-marin (3 cases)", "torpilleur (2 cases)" };
            int premBordColonne;
            string premBordLigne;
            int dernBordColonne;
            string dernBordLigne;

            Console.WriteLine("Souhaitez-vous jouer à deux ou tout seul ? Tapez deux ou seul");
            reponse = Console.ReadLine();
            Console.WriteLine("\n");
            if (reponse == "seul")
            {
                //tools.AfficherGrille(Jgrille2D,out alpha, out resultat);grille du joueur où il essaiera de deviner les bateau de l'adversaire
                //Console.WriteLine(resultat + "\n" + "\n");
                tools.AfficherGrille(BJgrille2D, out alpha, out resultat);// grille du joueur où il placera ses bateaux
                Console.WriteLine(resultat);
                Console.WriteLine("Placer les différents bateau à votre disposition :\n\n");
                Console.WriteLine("Ecrivez d'abord les extémités de la où vous voulez mettre vos bateau\nEn commmencant par les premières extrémités puis les dernières\n");

                for (int compteur = 0; compteur < bateau.Length; compteur++)
                {
                    Console.WriteLine("Placez le " + bateau[compteur] + "\n");

                    Console.WriteLine("Premières coordonnées :\n");
                    Console.WriteLine("Choisissez la colonne où vous voulez placer votre bateau");
                    premBordColonne = int.Parse(Console.ReadLine());
                    Console.WriteLine("Choisissez la ligne où vous voulez placer votre bateau");
                    premBordLigne = Console.ReadLine();

                    Console.WriteLine("Dernières coordonnées :\n");
                    Console.WriteLine("Choisissez la colonne où vous voulez placer votre bateau");
                    dernBordColonne = int.Parse(Console.ReadLine());
                    Console.WriteLine("Choisissez la ligne où vous voulez placer votre bateau");
                    dernBordLigne = Console.ReadLine();
                    tools.AfficherGrilleETBateau(premBordColonne, premBordLigne, dernBordColonne, dernBordLigne, bateau, BJgrille2D, resultat);
                }

                //Console.WriteLine("Placez le porte avion (5 cases)\n");

                //Console.WriteLine("Premières coordonnées :\n");
                //Console.WriteLine("Choisissez la colonne où vous voulez placer votre bateau");
                //premBordColonne = int.Parse(Console.ReadLine());
                //Console.WriteLine("Choisissez la ligne où vous voulez placer votre bateau");
                //premBordLigne = int.Parse(Console.ReadLine());

                //Console.WriteLine("Dernières coordonnées :\n");
                //Console.WriteLine("Choisissez la colonne où vous voulez placer votre bateau");
                //dernBordColonne = int.Parse(Console.ReadLine());
                //Console.WriteLine("Choisissez la ligne où vous voulez placer votre bateau");
                //dernBordLigne = int.Parse(Console.ReadLine());
                //tools.AfficherGrilleETBateau();

                //Console.WriteLine("Placez le croiseur (4 cases)\n");

                //Console.WriteLine("Premières coordonnées :\n");
                //Console.WriteLine("Choisissez la colonne où vous voulez placer votre bateau");
                //premBordColonne = int.Parse(Console.ReadLine());
                //Console.WriteLine("Choisissez la ligne où vous voulez placer votre bateau");
                //premBordLigne = int.Parse(Console.ReadLine());

                //Console.WriteLine("Dernières coordonnées :\n");
                //Console.WriteLine("Choisissez la colonne où vous voulez placer votre bateau");
                //dernBordColonne = int.Parse(Console.ReadLine());
                //Console.WriteLine("Choisissez la ligne où vous voulez placer votre bateau");
                //dernBordLigne = int.Parse(Console.ReadLine());
                //tools.AfficherGrilleETBateau();

                //Console.WriteLine("Placez le contre-croiseur (3 cases)\n");

                //Console.WriteLine("Premières coordonnées :\n");
                //Console.WriteLine("Choisissez la colonne où vous voulez placer votre bateau");
                //premBordColonne = int.Parse(Console.ReadLine());
                //Console.WriteLine("Choisissez la ligne où vous voulez placer votre bateau");
                //premBordLigne = int.Parse(Console.ReadLine());

                //Console.WriteLine("Dernières coordonnées :\n");
                //Console.WriteLine("Choisissez la colonne où vous voulez placer votre bateau");
                //dernBordColonne = int.Parse(Console.ReadLine());
                //Console.WriteLine("Choisissez la ligne où vous voulez placer votre bateau");
                //dernBordLigne = int.Parse(Console.ReadLine());
                //tools.AfficherGrilleETBateau();

                //Console.WriteLine("Placez le sous-marin (3 cases)\n");

                //Console.WriteLine("Premières coordonnées :\n");
                //Console.WriteLine("Choisissez la colonne où vous voulez placer votre bateau");
                //premBordColonne = int.Parse(Console.ReadLine());
                //Console.WriteLine("Choisissez la ligne où vous voulez placer votre bateau");
                //premBordLigne = int.Parse(Console.ReadLine());

                //Console.WriteLine("Dernières coordonnées :\n");
                //Console.WriteLine("Choisissez la colonne où vous voulez placer votre bateau");
                //dernBordColonne = int.Parse(Console.ReadLine());
                //Console.WriteLine("Choisissez la ligne où vous voulez placer votre bateau");
                //dernBordLigne = int.Parse(Console.ReadLine());
                //tools.AfficherGrilleETBateau();

                //Console.WriteLine("Placez le torpilleur (2 cases)\n");

                //Console.WriteLine("Premières coordonnées :\n");
                //Console.WriteLine("Choisissez la colonne où vous voulez placer votre bateau");
                //premBordColonne = int.Parse(Console.ReadLine());
                //Console.WriteLine("Choisissez la ligne où vous voulez placer votre bateau");
                //premBordLigne = int.Parse(Console.ReadLine());

                //Console.WriteLine("Dernières coordonnées :\n");
                //Console.WriteLine("Choisissez la colonne où vous voulez placer votre bateau");
                //dernBordColonne = int.Parse(Console.ReadLine());
                //Console.WriteLine("Choisissez la ligne où vous voulez placer votre bateau");
                //dernBordLigne = int.Parse(Console.ReadLine());
                //tools.AfficherGrilleETBateau();
            }
        }
    }
}
