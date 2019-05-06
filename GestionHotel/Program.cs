using System;
using GestionHotel.Classes;

namespace GestionHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix;

            do
            {                
                afficherMenu();
                choix = Convert.ToInt32(Console.ReadLine());

                if (choix == 1)
                {
                    int choixSousMenu;
                    Console.Clear();

                    do
                    {                 
                        afficherMenuClients();
                        choixSousMenu = Convert.ToInt32(Console.ReadLine());

                        switch (choixSousMenu)
                        {
                            case 1:
                                GestionClients.AffichageListeClient();
                                break;
                            case 2:
                                GestionClients.AjouterClient();
                                break;
                            case 3:
                                GestionClients.SupprimerClient();
                                break;
                            case 4:
                                choixSousMenu = 0;
                                break;
                        }
                    } while (choixSousMenu != 0);
                }
                else if (choix == 2)
                {
                    int choixSousMenu;
                    Console.Clear();

                    do
                    {
                        afficherMenuReservations();
                        choixSousMenu = Convert.ToInt32(Console.ReadLine());

                        switch (choixSousMenu)
                        {
                            case 1:
                                GestionReservation.AjouterReservation();
                                break;
                            case 2:
                                GestionReservation.ChangerStatut();
                                break;
                            case 3:
                                choixSousMenu = 0;
                                break;
                        }
                    } while (choixSousMenu != 0);
                }
                else if(choix == 3)
                {
                    Environment.Exit(0);
                }
            } while (choix != 0);

        }
        static void afficherMenu()
        {
            Console.Clear();
            Console.WriteLine("1- Gestion des Clients\n2- Gestion des réservations\n3- Quitter");
        }

        static void afficherMenuClients()
        {
            Console.WriteLine("1- Affichage des Clients\n2- Ajout d'un nouveau client\n3- Supprimer un client\n4- Retour");

        }

        static void afficherMenuReservations()
        {
            Console.WriteLine("1- Ajouter une réservation\n2- Changer de statut\n3- Retour");
        }
    }
}
