using Entities;
using System;

namespace Business
{
    public class UserServices
    {
        public void AddUserToRepository(User user)
        {
            Console.WriteLine("{0} has been added",user.UserName);
        }
        public void RegisterClientToUser(Tenant tenant, User user)
        {
            Console.WriteLine("{0} has rented {1}'s house", tenant.TenantName, user.UserName);
        }
    }
}
