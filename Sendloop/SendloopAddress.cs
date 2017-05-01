using Sendloop.Core;

namespace Sendloop {
    internal class SendloopAddress {
        private static readonly string BaseUrl = $"https://{SendloopInfo.Subdomain}.sendloop.com/api/v3/";

        /// <summary>
        /// Specify how you wish to receive the response from API. Available format options are "json", "xml", "php"
        /// </summary>
        private const string Format = "json";

        public static readonly string SubscriberImport = $"{BaseUrl}Subscriber.Import/{Format}";
        public static readonly string SubscriberSubscribe = $"{BaseUrl}Subscriber.Subscribe/{Format}";
        public static readonly string SubscriberUnsubscribe = $"{BaseUrl}Subscriber.Unsubscribe/{Format}";
        public static readonly string SubscriberSearch = $"{BaseUrl}Subscriber.Search/{Format}";
        public static readonly string SubscriberGet = $"{BaseUrl}Subscriber.Get/{Format}";
        public static readonly string SubscriberBrowse = $"{BaseUrl}Subscriber.Browse/{Format}";

        public static readonly string CampaignCreate = $"{BaseUrl}Campaign.Create/{Format}";
        public static readonly string CampaignSend = $"{BaseUrl}Campaign.Send/{Format}";
        public static readonly string CampaignGet = $"{BaseUrl}Campaign.Get/{Format}";
        public static readonly string CampaignUpdate = $"{BaseUrl}Campaign.Update/{Format}";
        public static readonly string CampaignGetList = $"{BaseUrl}Campaign.GetList/{Format}";
        public static readonly string CampaignDelete = $"{BaseUrl}Campaign.Delete/{Format}";
        public static readonly string CampaignResume = $"{BaseUrl}Campaign.Resume/{Format}";
        public static readonly string CampaignPause = $"{BaseUrl}Campaign.Pause/{Format}";
        public static readonly string CampaignCancel = $"{BaseUrl}Campaign.CancelSchedule/{Format}";

        public static readonly string SubscriberListGetList = $"{BaseUrl}List.GetList/{Format}";
        public static readonly string SubsriberListCreate = $"{BaseUrl}List.Create/{Format}";
        public static readonly string SubscriberListDelete = $"{BaseUrl}List.Delete/{Format}";
        public static readonly string SubscriberListUpdate = $"{BaseUrl}List.Update/{Format}";
        public static readonly string SubscriberListGet = $"{BaseUrl}List.Get/{Format}";

        public static readonly string SubscriberListSettingsGet = $"{BaseUrl}List.Settings.Get/{Format}";
        public static readonly string SubscriberListSettingsUpdate = $"{BaseUrl}List.Settings.Update/{Format}";

        public static readonly string SystemTimeZones = $"{BaseUrl}System.TimeZones.Get/{Format}";
        public static readonly string SystemDate = $"{BaseUrl}System.SystemDate.Get/{Format}";
        public static readonly string SystemCountries = $"{BaseUrl}System.Countries.Get/{Format}";
        public static readonly string SystemAccountDate = $"{BaseUrl}System.AccountDate.Get/{Format}";

        public static readonly string AccountInfo = $"{BaseUrl}Account.Info.Get/{Format}";
        public static readonly string AccountUpdate = $"{BaseUrl}Account.Info.Update/{Format}";
        public static readonly string AccountGetApiKeyList = $"{BaseUrl}Account.API.GetList/{Format}";
    }
}
