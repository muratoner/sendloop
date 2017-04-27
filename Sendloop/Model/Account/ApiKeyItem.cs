using Newtonsoft.Json;

namespace Sendloop.Model.Account {
    public class ApiKeyItem {
        [JsonProperty("APIKey")]
        public string ApiKey { get; set; }
        public string Note { get; set; }
        public string BoundIPs { get; set; }
    }
}
