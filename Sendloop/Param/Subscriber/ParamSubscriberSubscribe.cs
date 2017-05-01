using System.Collections.Generic;

namespace Sendloop.Param.Subscriber {
    public class ParamSubscriberSubscribe {
        /// <summary>
        /// [required]
        /// The email address which is going to be subscribed
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// [required]
        /// ID of the target subscriber list
        /// </summary>
        public int ListID { get; set; }
        /// <summary>
        /// [required]
        /// IP address of the subscriber
        /// </summary>
        public string SubscriptionIP { get; set; }
        /// <summary>
        /// If you are going to pass custom fields such as name or age, pass them in array here. 
        /// Example: CustomFieldX=John. X represents the ID number of the corresponding custom field.
        /// </summary>
        public Dictionary<string, string> Fields { get; set; }
    }
}
