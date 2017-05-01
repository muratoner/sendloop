using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sendloop.Extension;
using Sendloop.Model.SubscriberList;
using Sendloop.Param.SubscriberList;
using Sendloop.Result;

namespace Sendloop.Process.SubcriberList {

    using Result.SubscriberList;

    public class SubscriberList {
        private Lazy<HttpClientManager> Http { get; } = new Lazy<HttpClientManager>( () => new HttpClientManager() );

        #region GetList
        /// <summary>
        /// Returns the list of all active subscriber lists inside the Sendloop account.
        /// </summary>
        /// <returns></returns>
        public ResultSubscriberListGetList GetList()
            => Http.Value.Post<ResultSubscriberListGetList>( SendloopAddress.SubscriberListGetList );

        /// <summary>
        /// Returns the list of all active subscriber lists inside the Sendloop account.
        /// </summary>
        /// <returns></returns>
        public async Task<ResultSubscriberListGetList> GetListAsync()
            => await Http.Value.PostAsync<ResultSubscriberListGetList>( SendloopAddress.SubscriberListGetList );
        #endregion

        #region Create
        /// <summary>
        /// Create a new subscriber list.
        /// </summary>
        /// <returns></returns>
        public async Task<SubscriberListCreate> CreateAsync( ParamSubscriberListCreate param ) {
            var list = new Dictionary<string, string> {
                { nameof(param.Name), param.Name },
                { nameof(param.OptIn), param.OptIn.ToString() }
            };
            return await Http.Value.PostAsync<SubscriberListCreate>( SendloopAddress.SubsriberListCreate, list );
        }

        /// <summary>
        /// Create a new subscriber list.
        /// </summary>
        /// <returns></returns>
        public SubscriberListCreate Create( ParamSubscriberListCreate param )
            => CreateAsync( param ).GetAwaiter().GetResult();
        #endregion

        #region Delete
        /// <summary>
        /// Create a new subscriber list.
        /// </summary>
        /// <returns></returns>
        public async Task<ResultBase> DeleteAsync( int listId ) {
            var list = new Dictionary<string, string> {
                { "ListID", listId.ToString() }
            };
            return await Http.Value.PostAsync<ResultBase>( SendloopAddress.SubscriberListDelete, list );
        }

        /// <summary>
        /// Create a new subscriber list.
        /// </summary>
        /// <returns></returns>
        public ResultBase Delete( int listId )
            => DeleteAsync( listId ).GetAwaiter().GetResult();
        #endregion

        #region Get
        /// <summary>
        /// Retrieve details of a specific subscriber list
        /// </summary>
        /// <returns></returns>
        public async Task<ResultSubscriberListGet> GetAsync( ParamSubscriberListGet param ) {
            var list = new Dictionary<string, string> {
                { nameof(param.ListID), param.ListID.ToString() },
                { nameof(param.GetCustomFields), param.GetCustomFields.ToString() }
            };
            return await Http.Value.PostAsync<ResultSubscriberListGet>( SendloopAddress.SubscriberListGet, list );
        }

        /// <summary>
        /// Retrieve details of a specific subscriber list
        /// </summary>
        /// <returns></returns>
        public ResultSubscriberListGet Get( ParamSubscriberListGet param )
            => GetAsync( param ).GetAwaiter().GetResult();
        #endregion

        #region Update
        /// <summary>
        /// Update information of a subscriber list
        /// </summary>
        /// <returns></returns>
        public async Task<ResultBase> UpdateAsync( ParamSubscriberListUpdate param ) {
            var list = new Dictionary<string, string> {
                { nameof(param.ListID), param.ListID.ToString() }
            };

            if (param.Name.IsNotNullOrEmpty()) 
                list.Add(nameof(param.Name), param.Name);
            if( param.OptInMode.IsNotNull() )
                list.Add( nameof( param.OptInMode ), param.OptInMode.ToString() );

            return await Http.Value.PostAsync<ResultBase>( SendloopAddress.SubscriberListSettingsGet, list );
        }

        /// <summary>
        /// Update information of a subscriber list
        /// </summary>
        /// <returns></returns>
        public ResultBase Update( ParamSubscriberListUpdate param )
            => UpdateAsync( param ).GetAwaiter().GetResult();
        #endregion

        #region GetSettings
        /// <summary>
        /// Returns the settings of the target subscriber list
        /// </summary>
        /// <param name="listId">
        /// ID number of the target subscriber list
        /// </param>
        /// <returns></returns>
        public async Task<ResultSubscriberListSettings> GetSettingsAsync( int listId ) {
            var list = new Dictionary<string, string> {
                { "ListID", listId.ToString() }
            };
            return await Http.Value.PostAsync<ResultSubscriberListSettings>( SendloopAddress.SubscriberListSettingsGet, list );
        }

        /// <summary>
        /// Returns the settings of the target subscriber list
        /// </summary>
        /// <param name="listId">
        /// ID number of the target subscriber list
        /// </param>
        /// <returns></returns>
        public ResultSubscriberListSettings GetSettings( int listId )
            => GetSettingsAsync( listId ).GetAwaiter().GetResult();
        #endregion

        #region UpdateSettings
        /// <summary>
        /// Updates the subscriber list settings including opt-in confirmation and welcome email contents
        /// </summary>
        /// <returns></returns>
        public async Task<ResultBase> UpdateSettingsAsync( SubscriberListUpdateSettings param ) {
            var list = new Dictionary<string, string> {
                { nameof(param.ListID), param.ListID.ToString() }
            };

            if (param.SubscriptionFinalAction.IsNotNullOrEmpty())
                list.Add(nameof(param.SubscriptionFinalAction), param.SubscriptionFinalAction);
            if( param.SubscriptionFinalFromEmail.IsNotNullOrEmpty() )
                list.Add( nameof( param.SubscriptionFinalFromEmail ), param.SubscriptionFinalFromEmail );
            if( param.SubscriptionFinalFromName.IsNotNullOrEmpty() )
                list.Add( nameof( param.SubscriptionFinalFromName ), param.SubscriptionFinalFromName );
            if( param.SubscriptionFinalHTMLBody.IsNotNullOrEmpty() )
                list.Add( nameof( param.SubscriptionFinalHTMLBody ), param.SubscriptionFinalHTMLBody );
            if( param.SubscriptionFinalPlainBody.IsNotNullOrEmpty() )
                list.Add( nameof( param.SubscriptionFinalPlainBody ), param.SubscriptionFinalPlainBody );
            if( param.SubscriptionFinalSubject.IsNotNullOrEmpty() )
                list.Add( nameof( param.SubscriptionFinalSubject ), param.SubscriptionFinalSubject );
            if( param.SubscriptionOptInFromEmail.IsNotNullOrEmpty() )
                list.Add( nameof( param.SubscriptionOptInFromEmail ), param.SubscriptionOptInFromEmail );
            if( param.SubscriptionOptInFromName.IsNotNullOrEmpty() )
                list.Add( nameof( param.SubscriptionOptInFromName ), param.SubscriptionOptInFromName );
            if( param.SubscriptionOptInPlainBody.IsNotNullOrEmpty() )
                list.Add( nameof( param.SubscriptionOptInPlainBody ), param.SubscriptionOptInPlainBody );
            if( param.SubscriptionOptInSubject.IsNotNullOrEmpty() )
                list.Add( nameof( param.SubscriptionOptInSubject ), param.SubscriptionOptInSubject );
            if( param.WebServiceSubscriptionURL.IsNotNullOrEmpty() )
                list.Add( nameof( param.WebServiceSubscriptionURL ), param.WebServiceSubscriptionURL );
            if( param.WebServiceUnsubscriptionURL.IsNotNullOrEmpty() )
                list.Add( nameof( param.WebServiceUnsubscriptionURL ), param.WebServiceUnsubscriptionURL );

            return await Http.Value.PostAsync<ResultBase>( SendloopAddress.SubscriberListSettingsGet, list );
        }

        /// <summary>
        /// Updates the subscriber list settings including opt-in confirmation and welcome email contents
        /// </summary>
        /// <returns></returns>
        public ResultBase UpdateSettings( SubscriberListUpdateSettings param )
            => UpdateSettingsAsync( param ).GetAwaiter().GetResult();
        #endregion
    }
}
