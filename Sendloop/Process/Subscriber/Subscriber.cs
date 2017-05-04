using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Sendloop.Extension;
using Sendloop.Result;

namespace Sendloop.Process.Subscriber {

    using Param.Subscriber;
    using Result.Subscriber;

    public class Subscriber {

        private readonly Lazy<HttpClientManager> _http = new Lazy<HttpClientManager>( () => new HttpClientManager() );

        #region Import
        /// <summary>
        /// If you have a lot of email addresses to add into your subscriber list, you can use this bulk subscriber import API call.
        /// [HEADS UP] While we provide a bulk email address import API call, we monitor requests to this API call and in case of unfair usage, 
        /// your account may be suspended. Please do not import unauthorized email addresses, third party rented/purchased lists, 
        /// harvested email addresses or email addresses which have not given explicit authorization to you. For more details, 
        /// please refer to our <see href="http://ma92abd-abd8cf.sendloop.com/page/antispam_policy/">anti-spam policy</see>.
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public ResultSubscriberImport Import( ParamSubscriberImport param )
            => ImportAsync( param ).GetAwaiter().GetResult();

        /// <summary>
        /// If you have a lot of email addresses to add into your subscriber list, you can use this bulk subscriber import API call.
        /// [HEADS UP] While we provide a bulk email address import API call, we monitor requests to this API call and in case of unfair usage, 
        /// your account may be suspended. Please do not import unauthorized email addresses, third party rented/purchased lists, 
        /// harvested email addresses or email addresses which have not given explicit authorization to you. For more details, 
        /// please refer to our <see href="http://ma92abd-abd8cf.sendloop.com/page/antispam_policy/">anti-spam policy</see>.
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<ResultSubscriberImport> ImportAsync( ParamSubscriberImport param ) {
            var arry = new Dictionary<string, string> {
                {nameof(param.ListID), param.ListID.ToString()}
            };

            for ( var i = 0; i < param.Subscribers.Count; i++ ) {
                arry.Add( $"Subscribers[{i}][{nameof( Model.Subscriber.Subscriber.EmailAddress )}]", param.Subscribers[ i ].EmailAddress );
                for (int j = 0; j < param.Subscribers[i].Fields.Count; j++) {
                    arry.Add( $"Subscribers[{i}][{param.Subscribers[i].Fields.Keys.ElementAt(j)}]", param.Subscribers[i].Fields.Values.ElementAt(j) );
                }
            }

            return await _http.Value.PostAsync<ResultSubscriberImport>( SendloopAddress.SubscriberImport, arry );
        }
        #endregion

        #region Subscribe
        /// <summary>
        /// Subscribe an email address to the target subscriber list
        /// </summary>
        /// <returns></returns>
        public ResultSubscriberSubscribe Subscribe( ParamSubscriberSubscribe param )
            => SubscribeAsync( param ).GetAwaiter().GetResult();

        /// <summary>
        /// Subscribe an email address to the target subscriber list
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public async Task<ResultSubscriberSubscribe> SubscribeAsync( ParamSubscriberSubscribe param ) {

            if ( param.IsNull() )
                throw new ArgumentNullException( $"{nameof( param )}" );

            var arry = new Dictionary<string, string> {
                { nameof(param.ListID), param.ListID.ToString() },
                { nameof(param.EmailAddress), param.EmailAddress },
                { nameof(param.SubscriptionIP), param.SubscriptionIP }
            };

            if ( param.Fields.IsNotNull() )
                foreach ( var paramField in param.Fields )
                    arry.Add( $"Fields[{paramField.Key}]", paramField.Value );

            return await _http.Value.PostAsync<ResultSubscriberSubscribe>( SendloopAddress.SubscriberSubscribe, arry );
        }
        #endregion

        #region Update
        /// <summary>
        /// Update subscriber information
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public ResultBase Update( ParamSubscriberUpdate param )
            => UpdateAsync( param ).GetAwaiter().GetResult();

        /// <summary>
        /// Update subscriber information
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<ResultBase> UpdateAsync( ParamSubscriberUpdate param ) {
            if ( param.IsNull() )
                throw new ArgumentNullException( $"{nameof( param )}" );

            var arry = new Dictionary<string, string> {
                { nameof(param.ListID), param.ListID.ToString() }
            };

            arry.AddWithCondition( param.EmailAddress.IsNotNullOrEmpty(), nameof( param.EmailAddress ), param.EmailAddress );

            for ( int i = 0; i < param.Fields.Count; i++ )
                arry.Add( $"Fields[0][{param.Fields.Keys.ElementAt( i )}]", param.Fields.Values.ElementAt( i ) );

            return await _http.Value.PostAsync<ResultBase>( SendloopAddress.SubscriberUpdate, arry );
        }
        #endregion

        #region Browse
        /// <summary>
        /// Returns the list of subscribers for a specific list and segment
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <param name="listid">ID of the target list to get subscribers.</param>
        /// <returns></returns>
        public ResultSubscriberBrowse Browse( int listid )
            => BrowseAsync( new ParamSubscriberBrowse( listid ) ).GetAwaiter().GetResult();

        /// <summary>
        /// Returns the list of subscribers for a specific list and segment
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <param name="limit">Number of records to return in each API call. Default is 100.</param>
        /// <param name="listid">ID of the target list to get subscribers.</param>
        /// <returns></returns>
        public ResultSubscriberBrowse Browse( int listid, int limit )
            => BrowseAsync( new ParamSubscriberBrowse( listid, limit ) ).GetAwaiter().GetResult();

        /// <summary>
        /// Returns the list of subscribers for a specific list and segment
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public ResultSubscriberBrowse Browse( ParamSubscriberBrowse param )
            => BrowseAsync( param ).GetAwaiter().GetResult();

        /// <summary>
        /// Returns the list of subscribers for a specific list and segment
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public async Task<ResultSubscriberBrowse> BrowseAsync( ParamSubscriberBrowse param ) {
            if ( param.IsNull() ) {
                throw new ArgumentNullException( $"{nameof( param )}" );
            }

            var arry = new Dictionary<string, string> {
                { nameof(param.ListID), param.ListID.ToString() }
            };

            arry.AddWithCondition( param.Limit > 0, nameof( param.Limit ), param.Limit );
            arry.AddWithCondition( param.SegmentID > 0, nameof( param.SegmentID ), param.SegmentID );
            arry.AddWithCondition( param.StartIndex > 0, nameof( param.StartIndex ), param.StartIndex );

            return await _http.Value.PostAsync<ResultSubscriberBrowse>( SendloopAddress.SubscriberBrowse, arry );
        }
        #endregion

        #region Unsubscribe
        /// <summary>
        /// You can remove (unsubscribe) an email address from your list with this API call.
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public ResultSubscriberUnsubscribe Unsubscribe( ParamSubscriberUnsubscribe param )
            => UnsubscribeAsync( param ).GetAwaiter().GetResult();

        /// <summary>
        /// You can remove (unsubscribe) an email address from your list with this API call.
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<ResultSubscriberUnsubscribe> UnsubscribeAsync( ParamSubscriberUnsubscribe param ) {
            var arry = new Dictionary<string, string> {
                { nameof(param.ListID), param.ListID.ToString() },
                { nameof(param.EmailAddress), param.EmailAddress },
                { nameof(param.UnsubscriptionIP), param.UnsubscriptionIP }
            };

            return await _http.Value.PostAsync<ResultSubscriberUnsubscribe>( SendloopAddress.SubscriberUnsubscribe, arry );
        }
        #endregion

        #region Search
        /// <summary>
        /// This API command will search for subscribers based on your search criteria.
        /// </summary>
        /// <paramref name="email">
        /// [required]
        /// Search for email address across all your lists.
        /// </paramref>
        /// <returns></returns>
        public ResultSubscriberSearch Search( string email )
            => SearchAsync( email ).GetAwaiter().GetResult();

        /// <summary>
        /// This API command will search for subscribers based on your search criteria.
        /// </summary>
        /// <paramref name="email">
        /// [required]
        /// Search for email address across all your lists.
        /// </paramref>
        /// <returns></returns>
        public async Task<ResultSubscriberSearch> SearchAsync( string email ) {
            var arry = new Dictionary<string, string> {
                { "EmailAddress", email }
            };

            return await _http.Value.PostAsync<ResultSubscriberSearch>( SendloopAddress.SubscriberSearch, arry );
        }
        #endregion

        #region Get
        /// <summary>
        /// This API command will return the details of the target email address.
        /// </summary>
        /// <returns></returns>
        public ResultSubscriberGet Get( ParamSubscriberGet param )
            => GetAsync( param ).GetAwaiter().GetResult();

        /// <summary>
        /// This API command will return the details of the target email address.
        /// </summary>
        /// <returns></returns>
        public async Task<ResultSubscriberGet> GetAsync( ParamSubscriberGet param ) {
            var arry = new Dictionary<string, string> {
                { nameof(param.ListID), param.ListID.ToString() }
            };

            if ( param.EmailAddress.IsNotNullOrEmpty() )
                arry.Add( nameof( param.EmailAddress ), param.EmailAddress );
            if ( param.SubscriberID > 0 )
                arry.Add( nameof( param.SubscriberID ), param.SubscriberID.ToString() );

            return await _http.Value.PostAsync<ResultSubscriberGet>( SendloopAddress.SubscriberGet, arry );
        }
        #endregion
    }
}
