using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sendloop.Process.Campaign {

    using Core;
    using Param.Campaign;
    using Result;
    using Result.Campaign;

    public class Campaign {
        private Lazy<HttpClientManager> Http { get; } = new Lazy<HttpClientManager>( () => new HttpClientManager() );
        private SendloopInfo SendloopInfo { get; set; }

        public Campaign( SendloopInfo info ) {
            SendloopInfo = info;
        }

        #region Get
        /// <summary>
        /// Returns the settings of the target email campaign.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ResultCampaignGet Get( ParamCampaignGet model ) {
            var arry = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("APIKey", SendloopInfo.ApiKey),
                new KeyValuePair<string, string>(nameof(model.CampaignID), model.CampaignID.ToString()),
            };

            return Http.Value.Post<ResultCampaignGet, List<KeyValuePair<string, string>>>( SendloopAddress.CampaignGet, arry );
        }

        /// <summary>
        /// Returns the settings of the target email campaign.
        /// </summary>
        /// <param name="campaignId"></param>
        /// <returns></returns>
        public ResultCampaignGet Get( int campaignId )
            => Get( new ParamCampaignGet { CampaignID = campaignId } );

        /// <summary>
        /// Returns the settings of the target email campaign.
        /// </summary>
        /// <param name="campaignId"></param>
        /// <returns></returns>
        public async Task<ResultCampaignGet> GetAsync( int campaignId ) {
            var arry = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("APIKey", SendloopInfo.ApiKey),
                new KeyValuePair<string, string>("CampaignID", campaignId.ToString()),
            };

            return await Http.Value.PostAsync<ResultCampaignGet, List<KeyValuePair<string, string>>>( SendloopAddress.CampaignGet, arry );
        }
        #endregion

        #region Create
        /// <summary>
        /// Creates a new email campaign for the new email HTML code editor.
        /// </summary>
        /// <returns></returns>
        public ResultCampaign Create( ParamCampaignCreate model ) {
            var arry = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("APIKey", SendloopInfo.ApiKey),
                new KeyValuePair<string, string>("CampaignName", model.CampaignName),
                new KeyValuePair<string, string>("Subject", model.Subject),
                new KeyValuePair<string, string>("FromEmail", model.FromEmail),
                new KeyValuePair<string, string>("FromName", model.FromName),
                new KeyValuePair<string, string>("ReplyToEmail", model.ReplyToEmail),
                new KeyValuePair<string, string>("ReplyToName", model.ReplyToName),
                new KeyValuePair<string, string>("HTMLContent", model.HtmlContent),
            };

            for ( int i = 0; i < model.TargetListIDs.Length; i++ ) {
                arry.Add( new KeyValuePair<string, string>( $"TargetListIDs[{i}]", model.TargetListIDs[ i ].ToString() ) );
            }

            return Http.Value.Post<ResultCampaign, List<KeyValuePair<string, string>>>( SendloopAddress.CampaignCreate, arry );
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //public async Task<ResultCampaign> CreateAsync() {
        //    var http = new HttpClientManager();
        //    return await http.PostAsync<ResultCampaign, ParamCampaignCreate>("https://app.sendloop.com/api//v3/Campaign.Create/json", new ParamCampaignCreate
        //    {
        //        APIKey = SendloopInfo.ApiKey,
        //        CampaignName = "Test Name",
        //        Subject = "Test Subject"
        //    });
        //}
        #endregion

        #region Send
        /// <summary>
        /// Set a ready campaign to be sent immediately or in the future
        /// Heads Up!: The SendDate parameter should be set by considering the time-zone set in your Sendloop account. Please be sure that you have set the correct time-zone.
        /// </summary>
        /// <param name="campaignId"></param>
        /// <returns></returns>
        public ResultBase SendNow( int campaignId )
            => Send( new ParamCampaignSend { CampaignID = campaignId, SendDate = "NOW" } );

        /// <summary>
        /// Set a ready campaign to be sent immediately or in the future
        /// Heads Up!: The SendDate parameter should be set by considering the time-zone set in your Sendloop account. Please be sure that you have set the correct time-zone.
        /// </summary>
        /// <param name="send"></param>
        /// <returns></returns>
        public ResultBase Send( ParamCampaignSend send ) {
            var arry = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("APIKey", SendloopInfo.ApiKey),
                new KeyValuePair<string, string>(nameof(send.SendDate), send.SendDate),
                new KeyValuePair<string, string>(nameof(send.CampaignID), send.CampaignID.ToString()),
            };

            return Http.Value.Post<ResultBase, List<KeyValuePair<string, string>>>( SendloopAddress.CampaignSend, arry );
        }
        #endregion
    }
}
