using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Classes
{
    public class OutOfReservationException : Exception
    {
        public OutOfReservationException() : base("L'Hotel est complet")
        {
        }
    }
}
