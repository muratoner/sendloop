using System;
using System.Collections.Generic;

namespace Sendloop.Process.Subscriber {

    using Core;
    using Param.Subscriber;
    using Result.Subscriber;

    public class Subscriber {

        private readonly Lazy<HttpClientManager> _http = new Lazy<HttpClientManager>( () => new HttpClientManager() );

        private SendloopInfo SendloopInfo { get; set; }

        public Subscriber( SendloopInfo sendloopInfo ) {
            SendloopInfo = sendloopInfo;
        }

        public ResultSubscriberImport Import( ParamSubscriberImport param ) {
            var arry = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("APIKey", SendloopInfo.ApiKey),
                new KeyValuePair<string, string>(nameof(param.ListID), param.ListID.ToString())
            };

            for ( var i = 0; i < param.Subscribers.Count; i++ ) {
                arry.Add( new KeyValuePair<string, string>( $"Subscribers[{i}][CustomField2]", param.Subscribers[ i ].CustomField2 ) );
                arry.Add( new KeyValuePair<string, string>( $"Subscribers[{i}][CustomField3]", param.Subscribers[ i ].CustomField3 ) );
                arry.Add( new KeyValuePair<string, string>( $"Subscribers[{i}][EmailAddress]", param.Subscribers[ i ].EmailAddress ) );
            }

            return _http.Value.PostAsync<ResultSubscriberImport, IEnumerable<KeyValuePair<string, string>>>( SendloopAddress.SubscriberImport, arry ).GetAwaiter().GetResult();
        }
    }
}
