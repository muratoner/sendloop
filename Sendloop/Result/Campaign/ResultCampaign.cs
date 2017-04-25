namespace Sendloop.Result.Campaign {

    using Newtonsoft.Json;

    public class ResultCampaign : ResultBase {
        [JsonProperty( "CampaignID" )]
        public int CampaignId { get; set; }
    }
}
