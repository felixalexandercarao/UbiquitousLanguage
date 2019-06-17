using System;
using System.Collections.Generic;
using System.Text;
using ULEntities;

namespace ULBusiness
{
    public class TicketChecker
    {
        public static bool TicketCheck(Ticket  ticket)
        {
            if (String.IsNullOrEmpty(ticket.TicketBody))
            {
                return false;
            }
            return true;
        }

    }
}
