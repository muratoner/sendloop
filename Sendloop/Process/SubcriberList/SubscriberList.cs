using System;
using System.Collections.Generic;

namespace Sendloop.Process.SubcriberList {

    using Result.SubscriberList;
    using Core;

    public class SubscriberList {
        private Lazy<HttpClientManager> Http { get; } = new Lazy<HttpClientManager>( () => new HttpClientManager() );

        private SendloopInfo SendloopInfo { get; set; }

        public SubscriberList( SendloopInfo info ) {
            SendloopInfo = info;
        }

        /// <summary>
        /// Returns the list of all active subscriber lists inside the Sendloop account.
        /// </summary>
        /// <returns></returns>
        public ResultSubscriberListGetList GetList() {
            var arry = new List<KeyValuePair<string, string>> {
                new KeyValuePair<string, string>("APIKey", SendloopInfo.ApiKey)
            };

            return Http.Value.Post<ResultSubscriberListGetList, List<KeyValuePair<string, string>>>( SendloopAddress.SubscriberListGetList, arry );
        }
    }
}
