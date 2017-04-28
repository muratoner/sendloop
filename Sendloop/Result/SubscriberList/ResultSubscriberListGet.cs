using System.Collections.Generic;
using Sendloop.Model;
using Sendloop.Model.SubscriberList;

namespace Sendloop.Result.SubscriberList {
    public class ResultSubscriberListGet : ResultBase {
        public List<SubscriberListItem> List { get; set; }
        public IList<CustomField> CustomFields { get; set; }
    }
}
