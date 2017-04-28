using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sendloop.Extension;

namespace Sendloop.Process.Campaign {

    using Param.Campaign;
    using Result;
    using Result.Campaign;

    public class Campaign {
        private Lazy<HttpClientManager> Http { get; } = new Lazy<HttpClientManager>( () => new HttpClientManager() );

        public Campaign() {
        }

        #region Get
        /// <summary>
        /// Returns the settings of the target email campaign.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ResultCampaignGet Get( ParamCampaignGet model )
            => GetAsync( model ).GetAwaiter().GetResult();

        /// <summary>
        /// Returns the settings of the target email campaign.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<ResultCampaignGet> GetAsync( ParamCampaignGet model ) {
            var arry = new List<KeyValuePair<string, string>> {
                {nameof(model.CampaignID), model.CampaignID.ToString()}
            };

            return await Http.Value.PostAsync<ResultCampaignGet>( SendloopAddress.CampaignGet, arry );
        }

        /// <summary>
        /// Returns the settings of the target email campaign.
        /// </summary>
        /// <param name="campaignId"></param>
        /// <returns></returns>
        public ResultCampaignGet Get( int campaignId )
            => GetAsync( campaignId ).GetAwaiter().GetResult();

        /// <summary>
        /// Returns the settings of the target email campaign.
        /// </summary>
        /// <param name="campaignId"></param>
        /// <returns></returns>
        public async Task<ResultCampaignGet> GetAsync( int campaignId )
            => await GetAsync( new ParamCampaignGet { CampaignID = campaignId } );
        #endregion

        #region Create
        /// <summary>
        /// Creates a new email campaign for the new email HTML code editor.
        /// </summary>
        /// <returns></returns>
        public ResultCampaign Create( ParamCampaignCreate model )
            => CreateAsync( model ).GetAwaiter().GetResult();

        /// <summary>
        /// Creates a new email campaign for the new email HTML code editor.
        /// </summary>
        /// <returns></returns>
        public async Task<ResultCampaign> CreateAsync( ParamCampaignCreate model ) {
            var arry = new List<KeyValuePair<string, string>> {
                { nameof(model.CampaignName), model.CampaignName },
                { nameof(model.Subject), model.Subject },
                { nameof(model.FromEmail), model.FromEmail },
                { nameof(model.FromName), model.FromName },
                { nameof(model.ReplyToEmail), model.ReplyToEmail },
                { nameof(model.ReplyToName), model.ReplyToName },
                { nameof(model.HtmlContent), model.HtmlContent }
            };

            for( int i = 0; i < model.TargetListIDs.Length; i++ )
                arry.Add( $"TargetListIDs[{i}]", model.TargetListIDs[i].ToString() );

            return await Http.Value.PostAsync<ResultCampaign>( SendloopAddress.CampaignCreate, arry );
        }
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
        /// <param name="campaignId"></param>
        /// <returns></returns>
        public async Task<ResultBase> SendNowAsync( int campaignId )
            => await SendAsync( new ParamCampaignSend { CampaignID = campaignId, SendDate = "NOW" } );

        /// <summary>
        /// Set a ready campaign to be sent immediately or in the future
        /// Heads Up!: The SendDate parameter should be set by considering the time-zone set in your Sendloop account. Please be sure that you have set the correct time-zone.
        /// </summary>
        /// <param name="send"></param>
        /// <returns></returns>
        public ResultBase Send( ParamCampaignSend send )
            => SendAsync( send ).GetAwaiter().GetResult();

        /// <summary>
        /// Set a ready campaign to be sent immediately or in the future
        /// Heads Up!: The SendDate parameter should be set by considering the time-zone set in your Sendloop account. Please be sure that you have set the correct time-zone.
        /// </summary>
        /// <param name="send"></param>
        /// <returns></returns>
        public async Task<ResultBase> SendAsync( ParamCampaignSend send ) {
            var arry = new List<KeyValuePair<string, string>> {
                { nameof(send.SendDate), send.SendDate },
                { nameof(send.CampaignID), send.CampaignID.ToString() },
            };

            return await Http.Value.PostAsync<ResultBase>( SendloopAddress.CampaignSend, arry );
        }
        #endregion
    }
}
