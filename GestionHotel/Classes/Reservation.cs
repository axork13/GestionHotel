using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Classes
{
    public class Reservation
    {
        private int codeReservation;
        private int idClient;

        public int CodeReservation { get => codeReservation; set => codeReservation = value; }
        public int IdClient { get => idClient; set => idClient = value; }

        enum Statut
        {
            valide,
            annule
        }
    }
}
