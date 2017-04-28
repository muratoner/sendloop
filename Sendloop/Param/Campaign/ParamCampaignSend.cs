namespace Sendloop.Param.Campaign {
    /// <summary>
    /// Set a ready campaign to be sent immediately or in the future
    /// </summary>
    public class ParamCampaignSend {
        /// <summary>
        /// ID number of the target campaign
        /// </summary>
        public int CampaignID { get; set; }
        /// <summary>
        /// Date to send the campaign. Date should be formatted as YYYY-MM-DD HH:II:SS. If you want to send the campaign now, simply set this parameter to "NOW"
        /// </summary>
        public string SendDate { get; set; }
    }
}
