namespace Sendloop.Param.Campaign {

    /// <summary>
    /// Creates a new email campaign for the new email HTML code editor.
    /// </summary>
    public class ParamCampaignCreate : ParamBase {
        /// <summary>
        /// Subject of your email campaign
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// Name of your campaign
        /// </summary>
        public string CampaignName { get; set; }
        /// <summary>
        /// Name of the sender
        /// </summary>
        public string FromName { get; set; }
        /// <summary>
        /// Email address of the sender
        /// </summary>
        public string FromEmail { get; set; }
        /// <summary>
        /// Name of the person/organization who will receive replies
        /// </summary>
        public string ReplyToName { get; set; }
        /// <summary>
        /// Email address of the person/organization who will receive replies
        /// </summary>
        public string ReplyToEmail { get; set; }
        /// <summary>
        /// ID numbers of recipient lists. This parameter should be sent in array format
        /// </summary>
        public int[] TargetListIDs { get; set; }
        /// <summary>
        /// HTML content of your email campaign
        /// </summary>
        public string HtmlContent { get; set; }
    }
}
