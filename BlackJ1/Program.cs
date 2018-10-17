using System;

enum Sorte
{
    NONE = 0,
    COEUR = 1,
    PIQUE = 2,
    TREFLE = 3,
    CARREAU = 4,
}

namespace BlackJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generateur = new Random();
            int nbJetonJoueur1 = 100;
            int nbJetonJoueur2 = 100;
            int miseJoueur1;
            int miseJoueur2 = generateur.Next(1, 31);
            int TotalJoueur1 = 0;
            int TotalJoueur2 = 0;

            Sorte GenereSorte()
            {
                return (Sorte)generateur.Next(1, 5);
            }

            Random carteRandom = new Random();
            int Carte = carteRandom.Next(2, 15);
            int Carte2 = carteRandom.Next(2, 15);
            do
            {


                Console.WriteLine("Vous allez jouer une partit de Black Jack");
                Console.WriteLine("Appuyer sur une touche pour commencer");
                Console.ReadKey();


                do
                {
                    Console.WriteLine("Veuillez miser");
                    miseJoueur1 = Convert.ToInt32(Console.ReadLine());

                    if (miseJoueur1 <= nbJetonJoueur1)
                    {
                        Console.WriteLine("Votre mise et de " + miseJoueur1);
                    }
                    else if (miseJoueur1 > nbJetonJoueur1)
                    {
                        Console.WriteLine("Vous n avez pas asser de jeton veuiller re miser une autre somme");
                    }
                } while (miseJoueur1 > nbJetonJoueur1);



                switch (Carte)
                {
                    case 2:
                        Console.WriteLine("Vous avez piochez le " + Carte + " de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 2;
                        break;
                    case 3:
                        Console.WriteLine("Vous avez piochez le " + Carte + " de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 3;
                        break;
                    case 4:
                        Console.WriteLine("Vous avez piochez le " + Carte + " de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 4;
                        break;
                    case 5:
                        Console.WriteLine("Vous avez piochez le " + Carte + " de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 5;
                        break;
                    case 6:
                        Console.WriteLine("Vous avez piochez le " + Carte + " de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 6;
                        break;
                    case 7:
                        Console.WriteLine("Vous avez piochez le " + Carte + " de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 7;
                        break;
                    case 8:
                        Console.WriteLine("Vous avez piochez le de " + Carte + " de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 8;
                        break;
                    case 9:
                        Console.WriteLine("Vous avez piochez le de " + Carte + " de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 9;
                        break;
                    case 10:
                        Console.WriteLine("Vous avez piochez le de " + Carte + " de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 10;
                        break;
                    case 11:
                        Console.WriteLine("Vous avez piochez l'as de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 11;
                        break;
                    case 12:
                        Console.WriteLine("Vous avez piochez le valet de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 12;
                        break;
                    case 13:
                        Console.WriteLine("Vous avez piochez la Dame de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 13;
                        break;
                    case 14:
                        Console.WriteLine("Vous avez piochez le Roi de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 14;
                        break;
                }

                Console.WriteLine("Votre deuxieme carte est");
                Carte = carteRandom.Next(2, 15);
                switch (Carte)
                {
                    case 2:
                        Console.WriteLine("Vous avez piochez le " + Carte + " de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 2;
                        break;
                    case 3:
                        Console.WriteLine("Vous avez piochez le " + Carte + " de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 3;
                        break;
                    case 4:
                        Console.WriteLine("Vous avez piochez le " + Carte + " de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 4;
                        break;
                    case 5:
                        Console.WriteLine("Vous avez piochez le " + Carte + " de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 5;
                        break;
                    case 6:
                        Console.WriteLine("Vous avez piochez le " + Carte + " de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 6;
                        break;
                    case 7:
                        Console.WriteLine("Vous avez piochez le " + Carte + " de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 7;
                        break;
                    case 8:
                        Console.WriteLine("Vous avez piochez le de " + Carte + " de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 8;
                        break;
                    case 9:
                        Console.WriteLine("Vous avez piochez le de " + Carte + " de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 9;
                        break;
                    case 10:
                        Console.WriteLine("Vous avez piochez le de " + Carte + " de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 10;
                        break;
                    case 11:
                        Console.WriteLine("Vous avez piochez l'as de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 11;
                        break;
                    case 12:
                        Console.WriteLine("Vous avez piochez le valet de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 12;
                        break;
                    case 13:
                        Console.WriteLine("Vous avez piochez la Dame de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 13;
                        break;
                    case 14:
                        Console.WriteLine("Vous avez piochez le Roi de " + GenereSorte());
                        TotalJoueur1 = TotalJoueur1 + 14;
                        break;
                }

                Console.WriteLine("Votre total et de " + TotalJoueur1);
                Console.ReadKey();

                Console.WriteLine("Le joueur 2 va avoir ses carte");
                switch (Carte2)
                {
                    case 2:
                        Console.WriteLine("Vous avez piochez le " + Carte2 + " de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 2;
                        break;
                    case 3:
                        Console.WriteLine("Vous avez piochez le " + Carte2 + " de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 3;
                        break;
                    case 4:
                        Console.WriteLine("Vous avez piochez le " + Carte2 + " de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 4;
                        break;
                    case 5:
                        Console.WriteLine("Vous avez piochez le " + Carte2 + " de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 5;
                        break;
                    case 6:
                        Console.WriteLine("Vous avez piochez le " + Carte2 + " de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 6;
                        break;
                    case 7:
                        Console.WriteLine("Vous avez piochez le " + Carte2 + " de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 7;
                        break;
                    case 8:
                        Console.WriteLine("Vous avez piochez le de " + Carte2 + " de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 8;
                        break;
                    case 9:
                        Console.WriteLine("Vous avez piochez le de " + Carte2 + " de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 9;
                        break;
                    case 10:
                        Console.WriteLine("Vous avez piochez le de " + Carte2 + " de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 10;
                        break;
                    case 11:
                        Console.WriteLine("Vous avez piochez l'as de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 11;
                        break;
                    case 12:
                        Console.WriteLine("Vous avez piochez le valet de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 12;
                        break;
                    case 13:
                        Console.WriteLine("Vous avez piochez la Dame de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 13;
                        break;
                    case 14:
                        Console.WriteLine("Vous avez piochez le Roi de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 14;
                        break;
                }

                Console.WriteLine("Votre deuxieme carte est");
                Carte = carteRandom.Next(2, 15);
                switch (Carte2)
                {
                    case 2:
                        Console.WriteLine("Vous avez piochez le " + Carte2 + " de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 2;
                        break;
                    case 3:
                        Console.WriteLine("Vous avez piochez le " + Carte2 + " de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 3;
                        break;
                    case 4:
                        Console.WriteLine("Vous avez piochez le " + Carte2 + " de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 4;
                        break;
                    case 5:
                        Console.WriteLine("Vous avez piochez le " + Carte2 + " de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 5;
                        break;
                    case 6:
                        Console.WriteLine("Vous avez piochez le " + Carte2 + " de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 6;
                        break;
                    case 7:
                        Console.WriteLine("Vous avez piochez le " + Carte2 + " de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 7;
                        break;
                    case 8:
                        Console.WriteLine("Vous avez piochez le de " + Carte2 + " de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 8;
                        break;
                    case 9:
                        Console.WriteLine("Vous avez piochez le de " + Carte2 + " de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 9;
                        break;
                    case 10:
                        Console.WriteLine("Vous avez piochez le de " + Carte2 + " de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 10;
                        break;
                    case 11:
                        Console.WriteLine("Vous avez piochez l'as de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 11;
                        break;
                    case 12:
                        Console.WriteLine("Vous avez piochez le valet de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 12;
                        break;
                    case 13:
                        Console.WriteLine("Vous avez piochez la Dame de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 13;
                        break;
                    case 14:
                        Console.WriteLine("Vous avez piochez le Roi de " + GenereSorte());
                        TotalJoueur2 = TotalJoueur2 + 14;
                        break;
                }

                Console.WriteLine("Votre total et de " + TotalJoueur2);
                Console.ReadKey();

                if (nbJetonJoueur1 == 0)
                {
                    Console.WriteLine("Vous avez perdu NOOB");
                    Console.ReadKey();
                }
            } while (nbJetonJoueur1 > 0 && nbJetonJoueur2 > 0);
        }
    }
}

