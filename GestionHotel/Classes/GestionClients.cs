using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionHotel.Classes
{
    public static class GestionClients
    {
        public static List<Client> clients = new List<Client>();

        public static void AjouterClient()
        {
            Console.Clear();

            string nom, adresse, tel;

            Console.WriteLine("Quel est votre nom ?");
            nom = Console.ReadLine();
            Console.WriteLine("Quel est votre adresse ?");
            adresse = Console.ReadLine();
            Console.WriteLine("Quel est votre numéro de téléphone ?");
            tel = Console.ReadLine();

            try
            {
                clients.Add(new Client(getNextId(), nom, adresse, tel));
            }
            catch (NameEmptyOrNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (AdresseEmptyOrNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (TelFormatException e)
            {
                Console.WriteLine(e.Message);
            }

            AffichageListeClient();
        }

        public static void SupprimerClient()
        {
            Console.Clear();
            AffichageListeClient();
            Console.WriteLine("Quel est le numéro du client à supprimer ?");
            int id = Convert.ToInt32(Console.ReadLine());

            Client client = clients.SingleOrDefault(c => c.IdClient == id);
            try
            {
                if (client != null) clients.Remove(client);
                else throw new ClientInexistantException();
            }
            catch (ClientInexistantException e)
            {
                Console.WriteLine(e.Message + " avec un identifiant " + id);
            }
            
            //AffichageListeClient();
        }

        public static void AffichageListeClient()
        {
           //Console.Clear();

            try
            {
                if (clients.Count > 0)
                {
                    foreach (Client c in clients)
                    {
                        c.AfficherClient();
                        GestionReservation.Afficher(c.IdClient);
                    }
                }
                else
                {
                    throw new ClientInexistantException();
                }
            }
            catch (ClientInexistantException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();

        }

        static int getNextId()
        {
            int id = 0;
            if (clients.Count > 0) id = clients.Count;

            return id + 1;
        }
    }
}
