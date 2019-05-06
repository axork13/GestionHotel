using System;
using GestionHotel.Classes;

namespace GestionHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionClients.AffichageListeClient();

            GestionClients.AjouterClient();

            GestionClients.AjouterClient();

            GestionClients.AjouterClient();

            GestionClients.AffichageListeClient();

            GestionClients.SupprimerClient();

            GestionClients.AffichageListeClient();
            
        }
    }
}
