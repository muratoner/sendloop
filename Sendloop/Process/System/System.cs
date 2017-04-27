using System;
using System.Threading.Tasks;
using Sendloop.Result.System;

namespace Sendloop.Process.System {
    public class System {
        private readonly Lazy<HttpClientManager> _http = new Lazy<HttpClientManager>( () => new HttpClientManager() );

        #region GetTimeZones
        /// <summary>
        /// Returns the list of time zones defined on the system
        /// </summary>
        /// <returns></returns>
        public ResultSystemTimeZones GetTimeZones()
            => GetTimeZonesAsync().GetAwaiter().GetResult();

        /// <summary>
        /// Returns the list of time zones defined on the system
        /// </summary>
        /// <returns></returns>
        public async Task<ResultSystemTimeZones> GetTimeZonesAsync()
            => await _http.Value.PostAsync<ResultSystemTimeZones>( SendloopAddress.SystemTimeZones );
        #endregion

        #region GetSystemDate
        /// <summary>
        /// Returns the current date and time zone set on Sendloop servers
        /// </summary>
        /// <returns></returns>
        public ResultSystemDate GetSystemDate()
            => GetSystemDateAsync().GetAwaiter().GetResult();

        /// <summary>
        /// Returns the current date and time zone set on Sendloop servers
        /// </summary>
        /// <returns></returns>
        public async Task<ResultSystemDate> GetSystemDateAsync()
            => await _http.Value.PostAsync<ResultSystemDate>( SendloopAddress.SystemDate );
        #endregion

        #region GetCountries
        /// <summary>
        /// Returns the list of countries defined on the system
        /// </summary>
        /// <returns></returns>
        public ResultSystemCountries GetCountries()
            => GetCountriesAsync().GetAwaiter().GetResult();

        /// <summary>
        /// Returns the list of countries defined on the system
        /// </summary>
        /// <returns></returns>
        public async Task<ResultSystemCountries> GetCountriesAsync()
            => await _http.Value.PostAsync<ResultSystemCountries>( SendloopAddress.SystemCountries );
        #endregion

        #region GetAccountDate
        /// <summary>
        /// Returns the current date and time zone set in the user account settings
        /// </summary>
        /// <returns></returns>
        public ResultAccountDate GetAccountDate()
            => GetAccountDateAsync().GetAwaiter().GetResult();

        /// <summary>
        /// Returns the current date and time zone set in the user account settings
        /// </summary>
        /// <returns></returns>
        public async Task<ResultAccountDate> GetAccountDateAsync()
            => await _http.Value.PostAsync<ResultAccountDate>( SendloopAddress.SystemAccountDate );
        #endregion
    }
}
