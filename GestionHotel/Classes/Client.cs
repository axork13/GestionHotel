using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Classes
{
    public class Client
    {
        private int idClient;
        private string nomClient;
        private string adresseClient;
        private string telClient;

        public Client(int idClient, string nomClient, string adresseClient, string telClient)
        {
            this.IdClient = idClient;
            this.NomClient = nomClient;
            this.AdresseClient = adresseClient;
            this.TelClient = telClient;
        }

        public void AfficherClient()
        {
            Console.WriteLine("Id: " + idClient + " - Nom: " + nomClient + " - Adresse: " + adresseClient + " - Téléphone: " + telClient);
        }

        public int IdClient { get => idClient; set => idClient = value; }
        public string NomClient { get => nomClient; set => nomClient = value; }
        public string AdresseClient { get => adresseClient; set => adresseClient = value; }
        public string TelClient { get => telClient; set => telClient = value; }
    }
}
