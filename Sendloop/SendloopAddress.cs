using Sendloop.Extension;

namespace Sendloop {

    using Core;

    internal class SendloopAddress {
        private static readonly string BaseUrl = $"https://{( SendloopInfo.Subdomain.IsNotNullOrEmpty() ? SendloopInfo.Subdomain : "app" )}.sendloop.com/api/";

        /// <summary>
        /// Specify how you wish to receive the response from API. Available format options are "json", "xml", "php"
        /// </summary>
        private const string Format = "json";

        private const string Version = "v3";

        public static readonly string SubscriberImport = $"{BaseUrl}{Version}/Subscriber.Import/{Format}";
        public static readonly string SubscriberSubscribe = $"{BaseUrl}{Version}/Subscriber.Subscribe/{Format}";
        public static readonly string SubscriberUnsubscribe = $"{BaseUrl}{Version}/Subscriber.Unsubscribe/{Format}";
        public static readonly string SubscriberSearch = $"{BaseUrl}{Version}/Subscriber.Search/{Format}";
        public static readonly string SubscriberGet = $"{BaseUrl}{Version}/Subscriber.Get/{Format}";
        public static readonly string SubscriberBrowse = $"{BaseUrl}{Version}/Subscriber.Browse/{Format}";
        public static readonly string SubscriberUpdate = $"{BaseUrl}{Version}/Subscriber.Update/{Format}";

        public static readonly string SuppressionList = $"{BaseUrl}{Version}/Suppression.List.Getlist/{Format}";
        public static readonly string SuppressionListGet = $"{BaseUrl}{Version}/Suppression.List.Get/{Format}";
        public static readonly string SuppressionListAdd = $"{BaseUrl}{Version}/Suppression.List.Add/{Format}";

        public static readonly string CampaignCreate = $"{BaseUrl}{Version}/Campaign.Create/{Format}";
        public static readonly string CampaignSend = $"{BaseUrl}{Version}/Campaign.Send/{Format}";
        public static readonly string CampaignGet = $"{BaseUrl}{Version}/Campaign.Get/{Format}";
        public static readonly string CampaignUpdate = $"{BaseUrl}{Version}/Campaign.Update/{Format}";
        public static readonly string CampaignGetList = $"{BaseUrl}{Version}/Campaign.GetList/{Format}";
        public static readonly string CampaignDelete = $"{BaseUrl}{Version}/Campaign.Delete/{Format}";
        public static readonly string CampaignResume = $"{BaseUrl}{Version}/Campaign.Resume/{Format}";
        public static readonly string CampaignPause = $"{BaseUrl}{Version}/Campaign.Pause/{Format}";
        public static readonly string CampaignCancel = $"{BaseUrl}{Version}/Campaign.CancelSchedule/{Format}";
        public static readonly string CampaignGetListByStatus = $"{BaseUrl}{Version}/Campaign.GetListByStatus/{Format}";

        public static readonly string SubscriberListGetList = $"{BaseUrl}{Version}/List.GetList/{Format}";
        public static readonly string SubsriberListCreate = $"{BaseUrl}{Version}/List.Create/{Format}";
        public static readonly string SubscriberListDelete = $"{BaseUrl}{Version}/List.Delete/{Format}";
        public static readonly string SubscriberListUpdate = $"{BaseUrl}{Version}/List.Update/{Format}";
        public static readonly string SubscriberListGet = $"{BaseUrl}{Version}/List.Get/{Format}";

        public static readonly string SubscriberListSettingsGet = $"{BaseUrl}{Version}/List.Settings.Get/{Format}";
        public static readonly string SubscriberListSettingsUpdate = $"{BaseUrl}{Version}/List.Settings.Update/{Format}";

        public static readonly string SystemTimeZones = $"{BaseUrl}{Version}/System.TimeZones.Get/{Format}";
        public static readonly string SystemDate = $"{BaseUrl}{Version}/System.SystemDate.Get/{Format}";
        public static readonly string SystemCountries = $"{BaseUrl}{Version}/System.Countries.Get/{Format}";
        public static readonly string SystemAccountDate = $"{BaseUrl}{Version}/System.AccountDate.Get/{Format}";

        public static readonly string AccountInfo = $"{BaseUrl}{Version}/Account.Info.Get/{Format}";
        public static readonly string AccountUpdate = $"{BaseUrl}{Version}/Account.Info.Update/{Format}";
        public static readonly string AccountGetApiKeyList = $"{BaseUrl}{Version}/Account.API.GetList/{Format}";

        public static readonly string TransactionSendEmail = $"{BaseUrl}v4/mta.json";
        public static readonly string TransactionDeliveryStatusCheck = $"{BaseUrl}v4/mtamessages.json";
    }
}
