using Game1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Remove(Campaign campaign);

    }
}
