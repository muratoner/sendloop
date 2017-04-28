namespace Sendloop.Model.Subscriber {
    public class SubscriberGet {
        public string SubscriberID { get; set; }
        public string EmailAddress { get; set; }
        public string BounceType { get; set; }
        public string SubscriptionStatus { get; set; }
        public string SubscriptionDate { get; set; }
        public string SubscriptionIP { get; set; }
        public string UnsubscriptionDate { get; set; }
        public string UnsubscriptionIP { get; set; }
        public string OptInDate { get; set; }
    }
}
