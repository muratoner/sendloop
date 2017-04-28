namespace Sendloop {
    internal class SendloopAddress {
        private const string BaseUrl = "https://app.sendloop.com/api/v3/";

        public static readonly string SubscriberImport = $"{BaseUrl}Subscriber.Import";

        public static readonly string CampaignCreate = $"{BaseUrl}Campaign.Create";
        public static readonly string CampaignSend = $"{BaseUrl}Campaign.Send";
        public static readonly string CampaignGet = $"{BaseUrl}Campaign.Get";

        public static readonly string SubscriberListGetList = $"{BaseUrl}List.GetList";
        public static readonly string SubsriberListCreate = $"{BaseUrl}List.Create";
        public static readonly string SubscriberListDelete = $"{BaseUrl}List.Delete";
        public static readonly string SubscriberListUpdate = $"{BaseUrl}List.Update";
        public static readonly string SubscriberListGet = $"{BaseUrl}List.Get";
        public static readonly string SubscriberListSettingsGet = $"{BaseUrl}List.Settings.Get";
        public static readonly string SubscriberListSettingsUpdate = $"{BaseUrl}List.Settings.Update";

        public static readonly string SystemTimeZones = $"{BaseUrl}System.TimeZones.Get";
        public static readonly string SystemDate = $"{BaseUrl}System.SystemDate.Get";
        public static readonly string SystemCountries = $"{BaseUrl}System.Countries.Get";
        public static readonly string SystemAccountDate = $"{BaseUrl}System.AccountDate.Get";

        public static readonly string AccountInfo = $"{BaseUrl}Account.Info.Get";
        public static readonly string AccountUpdate = $"{BaseUrl}Account.Info.Update";
        public static readonly string AccountGetApiKeyList = $"{BaseUrl}Account.API.GetList";
    }
}
