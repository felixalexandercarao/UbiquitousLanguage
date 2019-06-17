using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class Helper
    {
        public static bool ConcernCheck(Concern concern)
        {
            if (String.IsNullOrEmpty(concern.ConcernBody))
            {
                return false;
            }
            return true;
        }
    }
}
