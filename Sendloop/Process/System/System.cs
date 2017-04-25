using Sendloop.Core;
using System;
using System.Collections.Generic;
using Sendloop.Result.System;

namespace Sendloop.Process.System {
    public class System {
        private readonly Lazy<HttpClientManager> _http = new Lazy<HttpClientManager>( () => new HttpClientManager() );

        private SendloopInfo SendloopInfo { get; set; }

        public System( SendloopInfo sendloopInfo ) {
            SendloopInfo = sendloopInfo;
        }

        /// <summary>
        /// Returns the list of time zones defined on the system
        /// </summary>
        /// <returns></returns>
        public ResultSystemTimeZones GetTimeZones() {
            var arry = new List<KeyValuePair<string, string>> {
                new KeyValuePair<string, string>("APIKey", SendloopInfo.ApiKey)
            };
            return _http.Value.Post<ResultSystemTimeZones, List<KeyValuePair<string, string>>>( SendloopAddress.SystemTimeZones, arry );
        }

        /// <summary>
        /// Returns the current date and time zone set on Sendloop servers
        /// </summary>
        /// <returns></returns>
        public ResultSystemDate GetSystemDate() {
            var arry = new List<KeyValuePair<string, string>> {
                new KeyValuePair<string, string>("APIKey", SendloopInfo.ApiKey)
            };
            return _http.Value.Post<ResultSystemDate, List<KeyValuePair<string, string>>>( SendloopAddress.SystemDate, arry );
        }

        /// <summary>
        /// Returns the list of countries defined on the system
        /// </summary>
        /// <returns></returns>
        public ResultSystemCountries GetCountries() {
            var arry = new List<KeyValuePair<string, string>> {
                new KeyValuePair<string, string>("APIKey", SendloopInfo.ApiKey)
            };
            return _http.Value.Post<ResultSystemCountries, List<KeyValuePair<string, string>>>( SendloopAddress.SystemCountries, arry );
        }

        /// <summary>
        /// Returns the current date and time zone set in the user account settings
        /// </summary>
        /// <returns></returns>
        public ResultAccountDate GetAccountDate() {
            var arry = new List<KeyValuePair<string, string>> {
                new KeyValuePair<string, string>("APIKey", SendloopInfo.ApiKey)
            };
            return _http.Value.Post<ResultAccountDate, List<KeyValuePair<string, string>>>( SendloopAddress.SystemAccountDate, arry );
        }
    }
}
