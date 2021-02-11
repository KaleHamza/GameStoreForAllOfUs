using System;
using System.Collections.Generic;
using System.Text;
using GameStoreForAllOfUs.Abstract;

namespace GameStoreForAllOfUs.Entities
{
    public class CampaignProduct:FirstPerson
    {
        public string PruductId { get; set; }
        public string PruductName { get; set; }
        public string PruductSeller { get; set; }
    }
}
