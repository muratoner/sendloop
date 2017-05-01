using System.Collections.Generic;

namespace Sendloop.Model.Campaign {
    public class CampaignGet : Campaign {
        public string SendProcessFinishedOn { get; set; }
        public IList<string> Lists { get; set; }
    }
}
