namespace Sendloop.Param.SubscriberList {
    public class ParamSubscriberListGet {
        /// <summary>
        /// ID number of the target subscriber list
        /// </summary>
        public int ListID { get; set; }

        /// <summary>
        /// If it's set to 1, API call will return the list of created custom fields for the target list. To disable this feature, set it to 0 (zero)
        /// </summary>
        public int GetCustomFields { get; set; }
    }
}
