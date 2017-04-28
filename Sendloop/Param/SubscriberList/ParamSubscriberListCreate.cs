using Sendloop.Enum;

namespace Sendloop.Param.SubscriberList {
    public class ParamSubscriberListCreate {
        /// <summary>
        /// [optional]
        /// Name of the new subscriber list.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// [required]
        /// Set the subscription type.It can be opt-in (no email confirmation will be sent ) or double opt-in (confirmation email will be sent - recommended).
        /// </summary>
        public OptInModeType OptIn { get; set; }
    }
}
