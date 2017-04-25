using System.Collections.Generic;

namespace Sendloop.Model.Campaign {
    public class Campaign {
        public int CampaignID { get; set; }
        public string CampaignStatus { get; set; }
        public string CampaignName { get; set; }
        public string FromName { get; set; }
        public string FromEmail { get; set; }
        public string ReplyToName { get; set; }
        public string ReplyToEmail { get; set; }
        public string FetchURL { get; set; }
        public string Subject { get; set; }
        public string PlainContent { get; set; }
        public string HTMLContent { get; set; }
        public string ScheduleType { get; set; }
        public string SendDate { get; set; }
        public string SendTime { get; set; }
        public string SendTimeZone { get; set; }
        public string SendProcessFinishedOn { get; set; }
        public int TotalRecipients { get; set; }
        public int TotalSent { get; set; }
        public int TotalFailed { get; set; }
        public int TotalOpens { get; set; }
        public int UniqueOpens { get; set; }
        public int TotalClicks { get; set; }
        public int UniqueClicks { get; set; }
        public int TotalForwards { get; set; }
        public int UniqueForwards { get; set; }
        public int TotalViewsOnBrowser { get; set; }
        public int UniqueViewsOnBrowser { get; set; }
        public int TotalUnsubscriptions { get; set; }
        public int TotalHardBounces { get; set; }
        public int TotalSoftBounces { get; set; }
        public string GoogleAnalyticsEnable { get; set; }
        public string GoogleAnalyticsDomains { get; set; }
        public string PublicTinyContentLink { get; set; }
        public IList<string> Lists { get; set; }
    }
}
