namespace Sendloop.Param.Subscriber {

    using System.Collections.Generic;

    public class ParamSubscriberUpdate {
        /// <summary>
        /// [required]
        /// ID of the target list to get subscribers.
        /// </summary>
        public int ListID { get; set; }

        /// <summary>
        /// [optional]
        /// ID number of the target subscriber.
        /// </summary>
        public int SubscriberID { get; set; }

        /// <summary>
        /// [optional]
        /// Email address of the subscriber.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// [optional]
        /// Custom fields to be updated. Example: Fields.Add("CustomField23",value)
        /// </summary>
        public Dictionary<string, string> Fields { get; set; }

        public ParamSubscriberUpdate() {
            Fields = new Dictionary<string, string>();
        }
    }
}
