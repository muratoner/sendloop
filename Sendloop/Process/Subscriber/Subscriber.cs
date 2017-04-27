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
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public ResultSubscriberImport Import( ParamSubscriberImport param )
            => ImportAsync( param ).GetAwaiter().GetResult();

        /// <summary>
        /// 
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
    }
}
