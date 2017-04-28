namespace Sendloop.Model.SubscriberList {
    public class SubscriberListSettings {
        public string SubscriptionOptInFromName { get; set; }
        public string SubscriptionOptInFromEmail { get; set; }
        public string SubscriptionOptInSubject { get; set; }
        public string SubscriptionOptInPlainBody { get; set; }
        public string SubscriptionFinalAction { get; set; }
        public string SubscriptionFinalFromName { get; set; }
        public string SubscriptionFinalFromEmail { get; set; }
        public string SubscriptionFinalSubject { get; set; }
        public string SubscriptionFinalHTMLBody { get; set; }
        public string SubscriptionFinalPlainBody { get; set; }
        public string WebServiceSubscriptionURL { get; set; }
        public string WebServiceUnsubscriptionURL { get; set; }
    }
}
