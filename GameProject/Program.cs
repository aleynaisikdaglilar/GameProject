using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { DateOfBirth = 1998, FirstName = "ALEYNA", LastName = "IŞIKDAĞLILAR", NationaltyId = 25168956896 });

            Campaign campaign = new Campaign { Id=1,Name= "Discount21" };
            

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);


            OrderManager orderManager = new OrderManager(new CampaignManager());
            orderManager.Order(new Order { GameName = "FIFA 21" });
        }
    }
}
