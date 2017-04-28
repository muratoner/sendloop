namespace Sendloop.Result.Account {

    using Newtonsoft.Json;
    using Model.Account;

    public class ResultGetApiList : ResultBase {
        [JsonProperty("APIKeys")]
        public ApiKeyItem[] ApiKeys { get; set; }
    }
}
