using System;
using System.Collections.Generic;
using System.Text;

namespace TicketMachine
{
    class Ticket

    {
        string movie;
        int serialNumber;
        static int nextNumber = 1001;


        public Ticket(string movie)
        {
            this.movie = movie;

            this.serialNumber = nextNumber++;
            

        }

        public override string ToString()
        {
            return String.Format("#Ticket [{0,5}, {1}]", serialNumber, movie);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Ticket))
                return false;

            Ticket temp = (Ticket)obj;
            return movie.Equals(temp.movie) && serialNumber == temp.serialNumber;

           
            //return obj is Ticket ticket &&
            //       serialNumber == ticket.serialNumber;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
