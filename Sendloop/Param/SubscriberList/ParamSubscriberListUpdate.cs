using Sendloop.Enum;

namespace Sendloop.Param.SubscriberList {
    public class ParamSubscriberListUpdate {
        /// <summary>
        /// [required]
        /// ID number of the target subscriber list
        /// </summary>
        public int ListID { get; set; }
        /// <summary>
        /// [optional]
        /// Name of the subscriber list
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// [optional] [Possible values: "Single", "Double"]
        /// Set the subscription type.It can be opt-in (no email confirmation will be sent ) or double opt-in (confirmation email will be sent - recommended). Pass "Single" or "Double"
        /// </summary>
        public OptInModeType OptInMode { get; set; }

        public ParamSubscriberListUpdate() {

        }

        public ParamSubscriberListUpdate( int listId, string name ) {
            ListID = listId;
            Name = name;
        }

        public ParamSubscriberListUpdate( int listId, string name, OptInModeType optInMode ) : this( listId, name ) {
            OptInMode = optInMode;
        }
    }
}
