namespace Sendloop.Param.Subscriber {

    using System.Collections.Generic;

    public class ParamSubscriberImport {
        /// <summary>
        /// [required]
        /// ID of the target subscriber list
        /// </summary>
        public int ListID { get; set; }
        /// <summary>
        /// [required]
        /// List of subscribers with their email address and any other available custom field information. This data should be passed in array format
        /// </summary>
        public List<Model.Subscriber.Subscriber> Subscribers { get; set; }
    }
}
