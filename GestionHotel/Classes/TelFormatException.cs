using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Classes
{
    public class TelFormatException : Exception
    {
        public TelFormatException() : base("Le numéro de téléphone n'est pas au bon format")
        {

        }
    }
}
