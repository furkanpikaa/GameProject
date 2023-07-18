using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        List<Campaign> campaigns = new List<Campaign>();

        public void Add(Campaign campaign)
        {
            if (campaign != null)
            {
                campaigns.Add(campaign);
            }
        }

        public void Delete(Campaign campaign)
        {
            if (campaign != null)
            {
                campaigns.Remove(campaign);
            }
        }

        public List<Campaign> GetAll()
        {
            var result = campaigns.ToList();
            if (result != null)
            {
                return result;
            }

            return null;
        }

        public Campaign GetById(int id)
        {
            var result = campaigns.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                return result;
            }
            return null;
        }

        public void Update(Campaign campaign)
        {
            var result = GetById(campaign.Id);

            if (result != null)
            {
                Delete(campaign);
                Add(campaign);
            }
        }
    }
}
