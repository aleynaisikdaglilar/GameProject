using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : IOrderService
    {
        ICampaignService _campaignService;

        public OrderManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void Order(Order order)
        {

            Console.WriteLine(order.GameName + " ordered");
        }
    }
}
