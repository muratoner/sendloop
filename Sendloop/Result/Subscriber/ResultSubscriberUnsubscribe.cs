using Newtonsoft.Json;

namespace Sendloop.Result.Subscriber {
    public class ResultSubscriberUnsubscribe : ResultBase {
        [JsonProperty("RedirectURL")]
        public string RedirectUrl { get; set; }
    }
}
