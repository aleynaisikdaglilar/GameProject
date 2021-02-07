using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if(_userValidationService.Validation(gamer)==true)
            {
                Console.WriteLine("Gamer added " + gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted " + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer updated " + gamer.FirstName);
        }
    }
}
