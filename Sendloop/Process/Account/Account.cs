using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sendloop.Extension;
using Sendloop.Model.Account;
using Sendloop.Result.Account;

namespace Sendloop.Process.Account {
    public class Account {
        private readonly Lazy<HttpClientManager> _http = new Lazy<HttpClientManager>( () => new HttpClientManager() );

        #region GetInfo
        /// <summary>
        /// Returns the Sendloop account information
        /// </summary>
        /// <returns></returns>
        public ResultAccountInfo GetInfo()
            => GetInfoAsync().GetAwaiter().GetResult();

        /// <summary>
        /// Returns the Sendloop account information
        /// </summary>
        /// <returns></returns>
        public async Task<ResultAccountInfo> GetInfoAsync()
            => await _http.Value.PostAsync<ResultAccountInfo>( SendloopAddress.AccountInfo );
        #endregion

        #region UpdateInfo
        /// <summary>
        /// Update the Sendloop account information
        /// </summary>
        /// <returns></returns>
        public ResultAccountInfo UpdateInfo( AccountInfoUpdate model )
            => UpdateInfoAsync( model ).GetAwaiter().GetResult();


        /// <summary>
        /// Update the Sendloop account information
        /// </summary>
        /// <returns></returns>
        public async Task<ResultAccountInfo> UpdateInfoAsync( AccountInfoUpdate model ) {
            var arry = new Dictionary<string, string>();

            arry.IfIsNotNullOrEmptyThenAdd( nameof( model.FirstName ), model.FirstName );
            arry.IfIsNotNullOrEmptyThenAdd( nameof( model.City ), model.City );
            arry.IfIsNotNullOrEmptyThenAdd( nameof( model.LastName ), model.LastName );
            arry.IfIsNotNullOrEmptyThenAdd( nameof( model.CompanyName ), model.CompanyName );
            arry.IfIsNotNullOrEmptyThenAdd( nameof( model.Country ), model.Country );
            arry.IfIsNotNullOrEmptyThenAdd( nameof( model.LastName ), model.LastName );
            arry.IfIsNotNullOrEmptyThenAdd( nameof( model.Email ), model.Email );
            arry.IfIsNotNullOrEmptyThenAdd( nameof( model.Fax ), model.Fax );
            arry.IfIsNotNullOrEmptyThenAdd( nameof( model.NewPassword ), model.NewPassword );
            arry.IfIsNotNullOrEmptyThenAdd( nameof( model.Phone ), model.Phone );
            arry.IfIsNotNullOrEmptyThenAdd( nameof( model.State ), model.State );
            arry.IfIsNotNullOrEmptyThenAdd( nameof( model.City ), model.City );
            arry.IfIsNotNullOrEmptyThenAdd( nameof( model.Street ), model.Street );
            arry.IfIsNotNullOrEmptyThenAdd( nameof( model.TimeZone ), model.TimeZone );
            arry.IfIsNotNullOrEmptyThenAdd( nameof( model.Username ), model.Username );
            arry.IfIsNotNullOrEmptyThenAdd( nameof( model.Website ), model.Website );
            arry.IfIsNotNullOrEmptyThenAdd( nameof( model.Zip ), model.Zip );

            return await _http.Value.PostAsync<ResultAccountInfo>( SendloopAddress.AccountUpdate, arry );
        }
        #endregion

        #region GetKeyList
        /// <summary>
        /// Returns the list of API keys available in the user account
        /// </summary>
        /// <returns></returns>
        public ResultGetApiList GetApiKeyList()
            => _http.Value.Post<ResultGetApiList>( SendloopAddress.AccountGetApiKeyList );

        /// <summary>
        /// Returns the list of API keys available in the user account
        /// </summary>
        /// <returns></returns>
        public async Task<ResultGetApiList> GetApiKeyListAsync()
            => await _http.Value.PostAsync<ResultGetApiList>( SendloopAddress.AccountGetApiKeyList );
        #endregion
    }
}
