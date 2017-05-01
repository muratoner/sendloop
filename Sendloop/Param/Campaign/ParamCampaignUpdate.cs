namespace Sendloop.Param.Campaign {
    public class ParamCampaignUpdate {
        public ParamCampaignUpdate() {
            TargetListIDs = new string[]{};
            TargetSegmentIDs = new string[]{};
            CustomerIDs = new string[]{};
        }

        /// <summary>
        /// [required]
        /// ID number of the target campaign
        /// </summary>
        public int CampaignID { get; set; }
        /// <summary>
        /// [optional]
        /// Name of your campaign.
        /// </summary>
        public string CampaignName { get; set; }
        /// <summary>
        /// [optional]
        /// The name which will in "from" email header.
        /// </summary>
        public string FromName { get; set; }
        /// <summary>
        /// [optional]
        /// Sender email address.
        /// </summary>
        public string FromEmail { get; set; }
        /// <summary>
        /// [optional]
        /// The name which will shown in "reply-to" email header.
        /// </summary>
        public string ReplyToName { get; set; }
        /// <summary>
        /// [optional]
        /// Email address to receive replies.
        /// </summary>
        public string ReplyToEmail { get; set; }
        /// <summary>
        /// [optional]
        /// ID numbers of recipient lists. 
        /// This parameter should be sent in array format.
        /// </summary>
        public string[] TargetListIDs { get; set; }
        /// <summary>
        /// [optional]
        /// ID numbers of recipient segments. 
        /// This parameter should be sent in array format.
        /// </summary>
        public string[] TargetSegmentIDs { get; set; }
        /// <summary>
        /// [optional]
        /// ID numbers of customer accounts you want to give access for reporting. 
        /// This parameter should be sent in array format.
        /// </summary>
        public string[] CustomerIDs { get; set; }
        /// <summary>
        /// [optional]
        /// Subject of your email campaign.
        /// </summary>
        public string Subject { get; set; }
    }
}
