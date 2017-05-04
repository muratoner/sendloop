using System.Collections.Generic;

namespace Sendloop.Model.Subscriber {
    public class Subscriber {
        public string EmailAddress { get; set; }
        public Dictionary<string, string> Fields { get; set; }

        public Subscriber() {
            Fields = new Dictionary<string, string>();
        }
    }
}
