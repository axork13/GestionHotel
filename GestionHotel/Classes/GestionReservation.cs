using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionHotel.Classes
{
    public static class GestionReservation
    {
        public static List<Reservation> reservations = new List<Reservation>();

        public static void AjouterReservation()
        {
            Console.Clear();

            Console.WriteLine("Quel est le numéro du client ?");
            int idClient = Convert.ToInt32(Console.ReadLine());

            reservations.Add(new Reservation(getNextCode(), idClient));
            GestionClients.AffichageListeClient();
        }

        public static void ChangerStatut()
        {
            Console.Clear();

            Console.WriteLine("Quel est le numéro du client ?");
            int id = Convert.ToInt32(Console.ReadLine());

            Reservation reservation = reservations.SingleOrDefault(r => r.IdClient == id);
            if (reservation != null) reservation.ChangerStatut();
            else Console.WriteLine("Il n'y a pas de réservation pour ce client");
            GestionClients.AffichageListeClient();
        }

        public static void Afficher(int id)
        {
            Reservation reservation = reservations.SingleOrDefault(r => r.IdClient == id);
            if (reservation != null) Console.WriteLine("CodeReservation: " + reservation.CodeReservation + " - statut: " + reservation.Statut);
            else Console.WriteLine("Il n'y a pas de réservation pour ce client");
        }

        static int getNextCode()
        {
            int id = 0;
            if (reservations.Count > 0) id = reservations.Count;

            return id + 1;
        }

    }
}
