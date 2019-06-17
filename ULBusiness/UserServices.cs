using Entities;
using System;
using ULEntities;

namespace ULBusiness
{
    public class ULUserServices
    {
        public void FileUsersTicket(Ticket ticket, User user)
        {
            if (TicketChecker.TicketCheck(ticket))
            {
                Console.WriteLine("{1} has filed his ticket : {0}", ticket.TicketBody, user.UserName);
            }
            else
            {
                Console.WriteLine("Your input is invalid");
            }
        }
    }
}
