using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Classes
{
    public class AdresseEmptyOrNullException : Exception
    {
        public AdresseEmptyOrNullException() : base("L'adresse doit être indiquée")
        {
        }
    }
}
