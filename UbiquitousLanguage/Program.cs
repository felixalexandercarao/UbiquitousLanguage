using Business;
using Entities;
using System;
using ULBusiness;
using ULEntities;

namespace UbiquitousLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            #region noUL
            User user = new User() { UserName = "Lex" };
            Console.Write("Please input your problem: ");
            string concernInput = Console.ReadLine();
            Concern concern = new Concern() { ConcernBody = concernInput, DateFiled = DateTime.Now };

            UserServices userServices = new UserServices();

            userServices.FileUsersConcern(concern, user);
            #endregion

            #region UL
            //Console.Write("Please input your problem: ");
            //string ticketInput = Console.ReadLine();
            //Ticket ticket = new Ticket() { TicketBody = ticketInput, DateFiled = DateTime.Now };

            //ULUserServices userServicesUL = new ULUserServices();

            //userServicesUL.FileUsersTicket(ticket, user); 
            #endregion
        }
    }
}
