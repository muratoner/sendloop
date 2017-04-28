using System.Collections.Generic;

namespace Sendloop.Model.Subscriber {
    public class SubscriberSearchResult {
        public int ListID { get; set; }
        public string ListName { get; set; }
        public Dictionary<int, string> Subscribers { get; set; }
    }
}
