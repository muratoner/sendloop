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
            var arry = new Dictionary<string, string> {
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
            var arry = new Dictionary<string, string> {
                { nameof(model.CampaignName), model.CampaignName },
                { nameof(model.Subject), model.Subject },
                { nameof(model.FromEmail), model.FromEmail },
                { nameof(model.FromName), model.FromName },
                { nameof(model.ReplyToEmail), model.ReplyToEmail },
                { nameof(model.ReplyToName), model.ReplyToName },
                { nameof(model.HtmlContent), model.HtmlContent }
            };

            for ( int i = 0; i < model.TargetListIDs.Length; i++ )
                arry.Add( $"TargetListIDs[{i}]", model.TargetListIDs[ i ].ToString() );

            return await Http.Value.PostAsync<ResultCampaign>( SendloopAddress.CampaignCreate, arry );
        }
        #endregion

        #region Update
        /// <summary>
        /// Update details of a Campaign.
        /// Updates the preferences of the target campaign.
        /// </summary>
        /// <returns></returns>
        public ResultBase Update( ParamCampaignUpdate param )
            => UpdateAsync( param ).GetAwaiter().GetResult();

        /// <summary>
        /// Update details of a Campaign.
        /// Updates the preferences of the target campaign.
        /// </summary>
        /// <returns></returns>
        public async Task<ResultBase> UpdateAsync( ParamCampaignUpdate param ) {
            var arry = new Dictionary<string, string> {
                { nameof(param.CampaignID), param.CampaignID.ToString() }
            };

            arry.AddWithCondition( param.CampaignName.IsNotNullOrEmpty(), nameof( param.CampaignName ), param.CampaignName );
            arry.AddWithCondition( param.FromName.IsNotNullOrEmpty(), nameof( param.FromName ), param.FromName );
            arry.AddWithCondition( param.FromEmail.IsNotNullOrEmpty(), nameof( param.FromEmail ), param.FromEmail );
            arry.AddWithCondition( param.ReplyToName.IsNotNullOrEmpty(), nameof( param.ReplyToName ), param.ReplyToName );
            arry.AddWithCondition( param.ReplyToEmail.IsNotNullOrEmpty(), nameof( param.ReplyToEmail ), param.ReplyToEmail );

            if ( param.TargetSegmentIDs.IsNotNull() && param.TargetSegmentIDs.Length > 0 )
                for ( int i = 0; i < param.TargetSegmentIDs.Length; i++ )
                    arry.AddWithCondition( param.TargetSegmentIDs[ i ].IsNotNullOrEmpty(), $"{nameof( param.TargetSegmentIDs )}[{i}]", param.TargetSegmentIDs[ i ] );

            if ( param.TargetListIDs.IsNotNull() && param.TargetListIDs.Length > 0 )
                for ( int i = 0; i < param.TargetListIDs.Length; i++ )
                    arry.AddWithCondition( param.TargetListIDs[ i ].IsNotNullOrEmpty(), $"{nameof( param.TargetListIDs )}[{i}]", param.TargetListIDs[ i ] );

            if ( param.CustomerIDs.IsNotNull() && param.CustomerIDs.Length > 0 )
                for ( int i = 0; i < param.CustomerIDs.Length; i++ )
                    arry.AddWithCondition( param.CustomerIDs[ i ].IsNotNullOrEmpty(), $"{nameof( param.CustomerIDs )}[{i}]", param.CustomerIDs[ i ] );

            return await Http.Value.PostAsync<ResultBase>( SendloopAddress.CampaignUpdate, arry );
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
            var arry = new Dictionary<string, string> {
                { nameof(send.SendDate), send.SendDate },
                { nameof(send.CampaignID), send.CampaignID.ToString() },
            };

            return await Http.Value.PostAsync<ResultBase>( SendloopAddress.CampaignSend, arry );
        }
        #endregion

        #region Pause
        /// <summary>
        /// Pause a sending campaign. It can be resumed at a later time.
        /// </summary>
        /// <param name="campaignId">
        /// [required]
        /// ID number of the target campaign.
        /// </param>
        /// <returns></returns>
        public ResultBase Pause( int campaignId )
            => PauseAsync( campaignId ).GetAwaiter().GetResult();

        /// <summary>
        /// Pause a sending campaign. It can be resumed at a later time.
        /// </summary>
        /// <param name="campaignId">
        /// [required]
        /// ID number of the target campaign.
        /// </param>
        /// <returns></returns>
        public async Task<ResultBase> PauseAsync( int campaignId ) {
            var arry = new Dictionary<string, string> {
                { "CampaignID", campaignId.ToString() }
            };
            return await Http.Value.PostAsync<ResultBase>( SendloopAddress.CampaignPause, arry );
        }
        #endregion

        #region Resume
        /// <summary>
        /// Resume a paused campaign. It can be paused at a later time.
        /// </summary>
        /// <param name="campaignId">
        /// [required]
        /// ID number of the target campaign.
        /// </param>
        /// <returns></returns>
        public ResultBase Resume( int campaignId )
            => ResumeAsync( campaignId ).GetAwaiter().GetResult();

        /// <summary>
        /// Resume a paused campaign. It can be paused at a later time.
        /// </summary>
        /// <param name="campaignId">
        /// [required]
        /// ID number of the target campaign.
        /// </param>
        /// <returns></returns>
        public async Task<ResultBase> ResumeAsync( int campaignId ) {
            var arry = new Dictionary<string, string> {
                { "CampaignID", campaignId.ToString() }
            };
            return await Http.Value.PostAsync<ResultBase>( SendloopAddress.CampaignResume, arry );
        }
        #endregion

        #region Cancel
        /// <summary>
        /// Cancel a campaign's schedule
        /// </summary>
        /// <param name="campaignId">
        /// [required]
        /// ID number of the target campaign.
        /// </param>
        /// <returns></returns>
        public ResultBase Cancel( int campaignId )
            => CancelAsync( campaignId ).GetAwaiter().GetResult();

        /// <summary>
        /// Cancel a campaign's schedule
        /// </summary>
        /// <param name="campaignId">
        /// [required]
        /// ID number of the target campaign.
        /// </param>
        /// <returns></returns>
        public async Task<ResultBase> CancelAsync( int campaignId ) {
            var arry = new Dictionary<string, string> {
                { "CampaignID", campaignId.ToString() }
            };
            return await Http.Value.PostAsync<ResultBase>( SendloopAddress.CampaignCancel, arry );
        }
        #endregion

        #region GetListByStatus
        /// <summary>
        /// Returns campaigns based on status.
        /// </summary>
        /// <returns></returns>
        public ResultCampaignGetListByStatus GetListByStatus(ParamCampaignGetListByStatus param)
            => GetListByStatusAsync(param).GetAwaiter().GetResult();

        /// <summary>
        /// Returns campaigns based on status.
        /// </summary>
        /// <returns></returns>
        public async Task<ResultCampaignGetListByStatus> GetListByStatusAsync(ParamCampaignGetListByStatus param) {
            var arry = new Dictionary<string, string> {
                { "CampaignStatus", param.CampaignStatus.ToString() }
            };
            return await Http.Value.PostAsync<ResultCampaignGetListByStatus>(SendloopAddress.CampaignGetListByStatus, arry);
        }
        #endregion

        #region GetList
        /// <summary>
        /// Returns the list of email campaigns you have in your Sendloop account
        /// </summary>
        /// <returns></returns>
        public ResultCampaignGetList GetList()
            => GetListAsync( null ).GetAwaiter().GetResult();

        /// <summary>
        /// Returns the list of email campaigns you have in your Sendloop account
        /// </summary>
        /// <returns></returns>
        public ResultCampaignGetList GetList( ParamCampaignList param )
            => GetListAsync( param ).GetAwaiter().GetResult();

        /// <summary>
        /// Returns the list of email campaigns you have in your Sendloop account
        /// </summary>
        /// <returns></returns>
        public async Task<ResultCampaignGetList> GetListAsync()
            => await GetListAsync( null );

        /// <summary>
        /// Returns the list of email campaigns you have in your Sendloop account
        /// </summary>
        /// <returns></returns>
        public async Task<ResultCampaignGetList> GetListAsync( ParamCampaignList param ) {

            if ( param.IsNull() )
                param = new ParamCampaignList();

            var arry = new Dictionary<string, string> {
                { nameof(param.IgnoreApproval), param.IgnoreApproval.ToBinary().ToString() },
                { nameof(param.IgnoreDrafts), param.IgnoreDrafts.ToBinary().ToString() },
                { nameof(param.IgnoreFailed), param.IgnoreFailed.ToBinary().ToString() },
                { nameof(param.IgnorePaused), param.IgnorePaused.ToBinary().ToString() },
                { nameof(param.IgnoreSending), param.IgnoreSending.ToBinary().ToString() },
                { nameof(param.IgnoreSent), param.IgnoreSent.ToBinary().ToString() }
            };

            return await Http.Value.PostAsync<ResultCampaignGetList>( SendloopAddress.CampaignGetList, arry );
        }
        #endregion

        #region Delete
        /// <summary>
        /// Delete the target campaign.
        /// </summary>
        /// <param name="campaignId">
        /// [required]
        /// ID number of the target campaign.
        /// </param>
        /// <returns></returns>
        public ResultBase Delete( int campaignId )
            => DeleteAsync( campaignId ).GetAwaiter().GetResult();

        /// <summary>
        /// Delete the target campaign.
        /// </summary>
        /// <param name="campaignId">
        /// [required]
        /// ID number of the target campaign.
        /// </param>
        /// <returns></returns>
        public async Task<ResultBase> DeleteAsync( int campaignId ) {
            var arry = new Dictionary<string, string> {
                { "CampaignID", campaignId.ToString() }
            };
            return await Http.Value.PostAsync<ResultBase>( SendloopAddress.CampaignDelete, arry );
        }
        #endregion
    }
}
