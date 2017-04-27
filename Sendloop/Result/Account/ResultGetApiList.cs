using Newtonsoft.Json;
using Sendloop.Model.Account;

namespace Sendloop.Result.Account {
    public class ResultGetApiList : ResultBase {
        [JsonProperty("APIKeys")]
        public ApiKeyItem[] ApiKeys { get; set; }
    }
}
