namespace Sendloop.Model.Subscriber {
    public class SubscriberBrowse {
        public int SubscriberID { get; set; }
        public string EmailAddress { get; set; }
        public string BounceType { get; set; }
        public string SubscriptionStatus { get; set; }
        public string SubscriptionDate { get; set; }
        public string SubscriptionIP { get; set; }
        public string UnsubscriptionDate { get; set; }
        public string UnsubscriptionIP { get; set; }
        public string OptInDate { get; set; }
        public string CustomField2 { get; set; }
    }
}
