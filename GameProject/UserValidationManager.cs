using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if((gamer.DateOfBirth==1998&&gamer.FirstName=="ALEYNA"&&gamer.LastName=="IŞIKDAĞLILAR"&&gamer.NationaltyId== 25168956896) ==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
