using Game1.Abstract;
using Game1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Concrete
{
    public class CampaingManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "kampanyası başladı");
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "kampanyası sona erdi");
        }
    }
}
