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
            string nom, adresse, tel;
            Console.WriteLine("Quel est votre nom ?");
            nom = Console.ReadLine();
            Console.WriteLine("Quel est votre adresse ?");
            adresse = Console.ReadLine();
            Console.WriteLine("Quel est votre numéro de téléphone ?");
            tel = Console.ReadLine();
            clients.Add(new Client(getNextId(), nom, adresse, tel));
        }

        public static void SupprimerClient()
        {
            Console.WriteLine("Quel est le numéro du client à supprimer ?");
            int id = Convert.ToInt32(Console.ReadLine());

            Client client = clients.SingleOrDefault(c => c.IdClient == id);
            if (client != null) clients.Remove(client);
            else Console.WriteLine("Ce client n'existe pas");
        }

        public static void AffichageListeClient()
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
                Console.WriteLine("Il n'y a pas de clients");
            }
        }

        static int getNextId()
        {
            int id = 0;
            if (clients.Count > 0) id = clients.Count;
            
            return id + 1;
        }
    }
}
