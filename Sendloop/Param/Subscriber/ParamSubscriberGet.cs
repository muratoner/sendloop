namespace Sendloop.Param.Subscriber {
    public class ParamSubscriberGet {
        /// <summary>
        /// [required]
        /// ID of the target subscriber list
        /// </summary>
        public int ListID { get; set; }
        /// <summary>
        /// ID of the target subscriber.
        /// </summary>
        public int SubscriberID { get; set; }
        /// <summary>
        /// Subscriber email address. Either the ID or Email address must be included in the API call.
        /// </summary>
        public string EmailAddress { get; set; }
    }
}
