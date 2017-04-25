using System;
using System.Collections.Generic;

namespace Sendloop.Model.SubscriberList {
    public class SubscriberList {
        public int ListID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public Dictionary<string, int> SubscriptionActivity { get; set; }
        public int ActiveSubscribers { get; set; }
    }
}
