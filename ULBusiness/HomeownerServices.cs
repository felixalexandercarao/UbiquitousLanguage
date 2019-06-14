using System;
using ULEntities;

namespace ULBusiness
{
    public class HomeownerServices
    {
        public void AddUserToRepository(Homeowner homeowner)
        {
            Console.WriteLine("{0} has been added", homeowner.HomeownerName);
        }
        public void RentHomeownersHouseToTenant(Tenant tenant, Homeowner homeowner)
        {
            Console.WriteLine("{0} has rented {1}'s house", tenant.TenantName, homeowner.HomeownerName);
        }
    }
}
