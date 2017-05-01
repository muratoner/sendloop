namespace Sendloop.Param.Campaign {
    public class ParamCampaignList {
        /// <summary>
        /// Set this field to true if you want to exclude drafts. Otherwise, set to false.
        /// </summary>
        public bool IgnoreDrafts { get; set; }
        /// <summary>
        /// Set this field to true if you want to exclude currently sending campaigns. Otherwise, set to false.
        /// </summary>
        public bool IgnoreSending { get; set; }
        /// <summary>
        /// Set this field to true if you want to exclude paused campaigns. Otherwise, set to false.
        /// </summary>
        public bool IgnorePaused { get; set; }
        /// <summary>
        /// Set this field to true if you want to exclude sent campaigns. Otherwise, set to false.
        /// </summary>
        public bool IgnoreSent { get; set; }
        /// <summary>
        /// Set this field to true if you want to exclude failed campaigns. Otherwise, set to false.
        /// </summary>
        public bool IgnoreFailed { get; set; }
        /// <summary>
        /// Set this field to true if you want to exclude approval pending campaigns. Otherwise, set to false.
        /// </summary>
        public bool IgnoreApproval { get; set; }
    }
}
