using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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

            this.NomClient = (!string.IsNullOrEmpty(nomClient) && !string.IsNullOrWhiteSpace(nomClient)) ? nomClient : throw new NameEmptyOrNullException();
            this.AdresseClient = (!string.IsNullOrEmpty(adresseClient) && !string.IsNullOrWhiteSpace(adresseClient)) ? adresseClient : throw new AdresseEmptyOrNullException();

            Regex r = new Regex(@"^0[1-6]{1}(([0-9]{2}){4})|((\s[0-9]{2}){4})|((-[0-9]{2}){4})$");
            if (r.IsMatch(telClient))
                this.TelClient = telClient;
            else
                throw new TelFormatException();

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
