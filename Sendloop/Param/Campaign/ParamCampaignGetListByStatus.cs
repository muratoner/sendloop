using Sendloop.Model.Campaign.Enum;

namespace Sendloop.Param.Campaign {
    public class ParamCampaignGetListByStatus {
        /// <summary>
        /// [required]
        /// Set the target campaign status. Available values: "Draft", "Scheduled", "Outbox", "Sent.
        /// </summary>
        public CampaignStatus CampaignStatus { get; set; }
        /// <summary>
        /// [optional]
        /// Number of records to return.
        /// </summary>
        public int Limit { get; set; }
        /// <summary>
        /// [optional]
        /// Set the page to return.
        /// </summary>
        public int Page { get; set; }
        /// <summary>
        /// [optional]
        /// Target field to sort rows. Available values: "CampaignID", "CampaignName", "SendTime".
        /// </summary>
        public OrderByField OrderByField { get; set; }
        /// <summary>
        /// [optional]
        /// Sorting type. Available values: "ASC" for ascending, "DESC" for descending.
        /// </summary>
        public OrderBySort OrderBySort { get; set; }
        /// <summary>
        /// [optional]
        /// If you provide a list ID, only campaigns sent to the target list will be returned.
        /// </summary>
        public int TargetListID { get; set; }
    }
}
