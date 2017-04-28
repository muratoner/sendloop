namespace Sendloop {
    internal class SendloopAddress {
        private const string BaseUrl = "https://app.sendloop.com/api/v3/";

        public static readonly string SubscriberImport = $"{BaseUrl}Subscriber.Import/json";
        public static readonly string SubscriberUnsubscribe = $"{BaseUrl}Subscriber.Unsubscribe/json";
        public static readonly string SubscriberSearch = $"{BaseUrl}Subscriber.Search/json";
        public static readonly string SubscriberGet = $"{BaseUrl}Subscriber.Get/json";

        public static readonly string CampaignCreate = $"{BaseUrl}Campaign.Create/json";
        public static readonly string CampaignSend = $"{BaseUrl}Campaign.Send/json";
        public static readonly string CampaignGet = $"{BaseUrl}Campaign.Get/json";

        public static readonly string SubscriberListGetList = $"{BaseUrl}List.GetList/json";
        public static readonly string SubsriberListCreate = $"{BaseUrl}List.Create/json";
        public static readonly string SubscriberListDelete = $"{BaseUrl}List.Delete/json";
        public static readonly string SubscriberListUpdate = $"{BaseUrl}List.Update/json";
        public static readonly string SubscriberListGet = $"{BaseUrl}List.Get/json";
        public static readonly string SubscriberListSettingsGet = $"{BaseUrl}List.Settings.Get/json";
        public static readonly string SubscriberListSettingsUpdate = $"{BaseUrl}List.Settings.Update/json";

        public static readonly string SystemTimeZones = $"{BaseUrl}System.TimeZones.Get/json";
        public static readonly string SystemDate = $"{BaseUrl}System.SystemDate.Get/json";
        public static readonly string SystemCountries = $"{BaseUrl}System.Countries.Get/json";
        public static readonly string SystemAccountDate = $"{BaseUrl}System.AccountDate.Get/json";

        public static readonly string AccountInfo = $"{BaseUrl}Account.Info.Get/json";
        public static readonly string AccountUpdate = $"{BaseUrl}Account.Info.Update/json";
        public static readonly string AccountGetApiKeyList = $"{BaseUrl}Account.API.GetList/json";
    }
}
