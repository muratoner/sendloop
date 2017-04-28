namespace Sendloop.Param.Subscriber {
    public class ParamSubscriberUnsubscribe {
        /// <summary>
        /// [required]
        /// Email address to be subscribed
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// [required]
        /// ID of the target subscriber list
        /// </summary>
        public int ListID { get; set; }
        /// <summary>
        /// [required]
        /// Subscriber's IP address. This is a legal requirement.
        /// </summary>
        public string UnsubscriptionIP { get; set; }
    }
}
