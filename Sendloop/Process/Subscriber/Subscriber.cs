using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sendloop.Extension;

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
            var arry = new List<KeyValuePair<string, string>> {
                {nameof(param.ListID), param.ListID.ToString()}
            };

            for ( var i = 0; i < param.Subscribers.Count; i++ ) {
                arry.Add( $"Subscribers[{i}][{nameof( Model.Subscriber.Subscriber.CustomField2 )}]", param.Subscribers[ i ].CustomField2 );
                arry.Add( $"Subscribers[{i}][{nameof( Model.Subscriber.Subscriber.CustomField3 )}]", param.Subscribers[ i ].CustomField3 );
                arry.Add( $"Subscribers[{i}][{nameof( Model.Subscriber.Subscriber.EmailAddress )}]", param.Subscribers[ i ].EmailAddress );
            }

            return await _http.Value.PostAsync<ResultSubscriberImport>( SendloopAddress.SubscriberImport, arry );
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
            var arry = new List<KeyValuePair<string, string>> {
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
            var arry = new List<KeyValuePair<string, string>> {
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
            var arry = new List<KeyValuePair<string, string>> {
                { nameof(param.ListID), param.ListID.ToString() }
            };

            if (param.EmailAddress.IsNotNullOrEmpty())
                arry.Add(nameof(param.EmailAddress), param.EmailAddress);
            if(param.SubscriberID > 0)
                arry.Add(nameof(param.SubscriberID), param.SubscriberID.ToString());

            return await _http.Value.PostAsync<ResultSubscriberGet>( SendloopAddress.SubscriberGet, arry );
        }
        #endregion
    }
}
