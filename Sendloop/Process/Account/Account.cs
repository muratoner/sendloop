using System;
using System.Collections.Generic;
using Sendloop.Core;
using Sendloop.Result.Account;

namespace Sendloop.Process.Account {
    public class Account {
        private readonly Lazy<HttpClientManager> _http = new Lazy<HttpClientManager>( () => new HttpClientManager() );

        private SendloopInfo SendloopInfo { get; set; }

        public Account( SendloopInfo sendloopInfo ) {
            SendloopInfo = sendloopInfo;
        }

        /// <summary>
        /// Returns the Sendloop account information
        /// </summary>
        /// <returns></returns>
        public ResultAccountInfo GetInfo() {
            var arry = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("APIKey", SendloopInfo.ApiKey)
            };

            return _http.Value.Post<ResultAccountInfo, List<KeyValuePair<string, string>>>( SendloopAddress.AccountInfo, arry );
        }
    }
}
