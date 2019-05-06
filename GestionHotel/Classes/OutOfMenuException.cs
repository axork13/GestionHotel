using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Classes
{
    public class OutOfMenuException : Exception
    {
        public OutOfMenuException() : base("Le choix sélectionné n'existe pas")
        {

        }
    }
}
