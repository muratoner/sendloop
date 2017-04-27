namespace Sendloop {
    internal class SendloopAddress {
        private const string BaseUrl = "https://app.sendloop.com/api/v3/";

        public static readonly string SubscriberImport = $"{BaseUrl}Subscriber.Import/json";

        public static readonly string CampaignCreate = $"{BaseUrl}Campaign.Create/json";
        public static readonly string CampaignSend = $"{BaseUrl}Campaign.Send/json";
        public static readonly string CampaignGet = $"{BaseUrl}Campaign.Get/json";

        public static readonly string SubscriberListGetList = $"{BaseUrl}List.GetList/json";

        public static readonly string SystemTimeZones = $"{BaseUrl}System.TimeZones.Get/json";
        public static readonly string SystemDate = $"{BaseUrl}System.SystemDate.Get/json";
        public static readonly string SystemCountries = $"{BaseUrl}System.Countries.Get/json";
        public static readonly string SystemAccountDate = $"{BaseUrl}System.AccountDate.Get";

        public static readonly string AccountInfo = $"{BaseUrl}Account.Info.Get";
        public static readonly string AccountUpdate = $"{BaseUrl}Account.Info.Update";
        public static readonly string AccountGetApiKeyList = $"{BaseUrl}Account.API.GetList";
    }
}
