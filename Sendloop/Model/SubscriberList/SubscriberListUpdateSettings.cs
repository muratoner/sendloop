namespace Sendloop.Model.SubscriberList {
    public class SubscriberListUpdateSettings {
        /// <summary>
        /// ID number of the target subscriber list
        /// </summary>
        public int ListID { get; set; }
        /// <summary>
        /// Sender name for opt-in confirmation email
        /// </summary>
        public string SubscriptionOptInFromName { get; set; }
        /// <summary>
        /// Sender email address for opt-in confirmation email
        /// </summary>
        public string SubscriptionOptInFromEmail { get; set; }
        /// <summary>
        /// Subject of the opt-in confirmation email
        /// </summary>
        public string SubscriptionOptInSubject { get; set; }
        /// <summary>
        /// Text content of the opt-in confirmation email
        /// </summary>
        public string SubscriptionOptInPlainBody { get; set; }
        /// <summary>
        /// What to do once subscription is confirmed: "Nothing" or "Send Email". If "Send Email" is set, Sendloop will send the welcome email once subscription is confirmed
        /// </summary>
        public string SubscriptionFinalAction { get; set; }
        /// <summary>
        /// Welcome email sender name
        /// </summary>
        public string SubscriptionFinalFromName { get; set; }
        /// <summary>
        /// Welcome email sender email address
        /// </summary>
        public string SubscriptionFinalFromEmail { get; set; }
        /// <summary>
        /// Subject of the welcome email
        /// </summary>
        public string SubscriptionFinalSubject { get; set; }
        /// <summary>
        /// HTML email content of the welcome email
        /// </summary>
        public string SubscriptionFinalHTMLBody { get; set; }
        /// <summary>
        /// Text email content of the welcome email
        /// </summary>
        public string SubscriptionFinalPlainBody { get; set; }
        /// <summary>
        /// Webhook URL to post subscriber data once the subscription is confirmed
        /// </summary>
        public string WebServiceSubscriptionURL { get; set; }
        /// <summary>
        /// Webhook URL to post subscriber data once the unsubscription request is processed
        /// </summary>
        public string WebServiceUnsubscriptionURL { get; set; }
    }
}
