using Entities;
using System;

namespace Business
{
    public class UserServices
    {

        public void FileUsersConcern(Concern concern, User user)
        {
            if (Helper.ConcernCheck(concern))
            { 
                Console.WriteLine("{1} has filed his concern : {0}", concern.ConcernBody, user.UserName);
            }
            else
            {
                Console.WriteLine("Your input is invalid");
            }
        }
    }
}
