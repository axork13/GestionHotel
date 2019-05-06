using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Classes
{
    public class ClientInexistantException : Exception
    {
        public ClientInexistantException() : base("Il n'y a pas de clients")
        {

        }
    }
}
