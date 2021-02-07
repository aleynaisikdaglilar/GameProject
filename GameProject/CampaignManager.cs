using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign added " + campaign.Name);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign deleted " + campaign.Name);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign updated " + campaign.Name);
        }
    }
}
