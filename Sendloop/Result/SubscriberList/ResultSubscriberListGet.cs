using System.Collections.Generic;
using Sendloop.Model;
using Sendloop.Model.SubscriberList;

namespace Sendloop.Result.SubscriberList {
    public class ResultSubscriberListGet : ResultBase {
        public SubscriberListItem List { get; set; }
        public CustomField[] CustomFields { get; set; }
    }
}
