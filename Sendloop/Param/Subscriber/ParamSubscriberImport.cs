namespace Sendloop.Param.Subscriber {

    using System.Collections.Generic;

    public class ParamSubscriberImport : ParamBase {
        public int ListID { get; set; }
        public List<Model.Subscriber.Subscriber> Subscribers { get; set; }
    }
}
