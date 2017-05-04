namespace Sendloop.Param.Subscriber {
    public class ParamSubscriberBrowse {
        /// <summary>
        /// [required]
        /// ID of the target list to get subscribers.
        /// </summary>
        public int ListID { get; set; }
        /// <summary>
        /// [optional]
        /// ID of the segment in the target list to get subscribers.
        /// </summary>
        public int SegmentID { get; set; }
        /// <summary>
        /// [optional]
        /// Page index to get subscribers from. Default is 0.
        /// </summary>
        public int StartIndex { get; set; }
        /// <summary>
        /// [optional]
        /// Number of records to return in each API call. Default is 100.
        /// </summary>
        public int Limit { get; set; }

        public ParamSubscriberBrowse() {

        }

        public ParamSubscriberBrowse( int listId ) {
            ListID = listId;
        }

        public ParamSubscriberBrowse( int listId, int limit ) : this( listId ) {
            Limit = limit;
        }
    }
}
