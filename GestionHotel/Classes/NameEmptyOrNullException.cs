using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Classes
{
    public class NameEmptyOrNullException : Exception
    {
        public NameEmptyOrNullException() : base("Le nom doit être spécifié")
        {
        }
    }
}
