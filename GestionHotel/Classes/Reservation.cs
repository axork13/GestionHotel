using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Classes
{
    public class Reservation
    {
        public enum enumStatut
        {
            valide,
            annule
        }

        private int codeReservation;
        private int idClient;
        private enumStatut statut;

        public Reservation(int codeReservation, int idClient)
        {
            this.codeReservation = codeReservation;
            this.idClient = idClient;
            this.statut = enumStatut.valide;
        }

        public void ChangerStatut()
        {
            if (this.statut == enumStatut.valide)
                this.statut = enumStatut.annule;
            else
                this.statut = enumStatut.valide;
        }

        public int CodeReservation { get => codeReservation; set => codeReservation = value; }
        public int IdClient { get => idClient; set => idClient = value; }
        public enumStatut Statut { get => statut; set => statut = value; }
    }
}
