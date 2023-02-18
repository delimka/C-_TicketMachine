using System;
using System.Collections.Generic;
using System.Text;

namespace TicketMachine
{
    class TicketMachine
    {
        static List<Ticket> legalTickets = new List<Ticket>();

        public Ticket BuyTicket(string movie)
        {
            Ticket ticket = new Ticket(movie);
            legalTickets.Add(ticket);
            return ticket;
        }
        

        public bool IsValid (Ticket ticket)

        {
            foreach (Ticket t in legalTickets)
            {

                if (ticket.Equals(t))
                    return true;

            }

            return false;

        }


        public void UseTicket(Ticket t)

        {
            if (!IsValid(t))

            {

                Console.WriteLine("Alarm! {0} is not valid!", t);

            }
            else
            {
                Console.WriteLine("Have a nice day!");
                legalTickets.Remove(t);
            }

        }


    }


}
