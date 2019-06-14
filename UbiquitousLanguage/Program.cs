using Business;
using Entities;
using System;

namespace UbiquitousLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { UserName="UserDino"};
            Tenant tenant = new Tenant() { TenantName="TenantLex"};
            
            UserServices userServices = new UserServices();

            userServices.RegisterClientToUser(tenant, user);
        }
    }
}
