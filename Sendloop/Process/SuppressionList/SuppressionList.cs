using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sendloop.Result.SuppressionList;

namespace Sendloop.Process.SuppressionList {
    public class SuppressionList {

        private readonly Lazy<HttpClientManager> _http = new Lazy<HttpClientManager>( () => new HttpClientManager() );

        #region List
        /// <summary>
        /// Returns list of suppression entries
        /// </summary>
        /// <param name="listId">
        /// [required]
        /// ID number of the target list. If you set this to 0, it will return all globally set suppression list entries
        /// </param>
        /// <returns></returns>
        public ResultSuppressionList List( int listId )
            => ListAsync( listId ).GetAwaiter().GetResult();

        /// <summary>
        /// Returns list of suppression entries
        /// </summary>
        /// <param name="listId">
        /// [required]
        /// ID number of the target list. If you set this to 0, it will return all globally set suppression list entries
        /// </param>
        /// <returns></returns>
        public async Task<ResultSuppressionList> ListAsync( int listId ) {
            var arry = new Dictionary<string, string> {
                { "ListID", listId.ToString() }
            };
            return await _http.Value.PostAsync<ResultSuppressionList>( SendloopAddress.SuppressionList, arry );
        }
        #endregion

        #region Get
        /// <summary>
        /// Returns the suppression list entry of a specific email address
        /// </summary>
        /// <param name="email">
        /// [required]
        /// Email address to search
        /// </param>
        /// <returns></returns>
        public ResultSuppressionListGet Get( string email )
            => GetAsync( email ).GetAwaiter().GetResult();

        /// <summary>
        /// Returns the suppression list entry of a specific email address
        /// </summary>
        /// <param name="email">
        /// [required]
        /// Email address to search
        /// </param>
        /// <returns></returns>
        public async Task<ResultSuppressionListGet> GetAsync( string email ) {
            var arry = new Dictionary<string, string> {
                { "EmailAddress", email }
            };
            return await _http.Value.PostAsync<ResultSuppressionListGet>( SendloopAddress.SuppressionListGet, arry );
        }
        #endregion

        #region Add
        /// <summary>
        /// Add email addresses to the suppression list.
        /// </summary>
        /// <param name="listId">
        /// [required]
        /// Target list ID. Set this parameter zero (0) to suppress globally on your account.
        /// </param>
        /// <param name="email">
        /// [required]
        /// Email address to search.
        /// </param>
        /// <returns></returns>
        public ResultSuppressionListAdd Add( int listId, string email )
            => AddAsync( listId, email ).GetAwaiter().GetResult();

        /// <summary>
        /// Add email addresses to the suppression list.
        /// </summary>
        /// <param name="listId">
        /// [required]
        /// Target list ID. Set this parameter zero (0) to suppress globally on your account.
        /// </param>
        /// <param name="email">
        /// [required]
        /// Email address to search.
        /// </param>
        /// <returns></returns>
        public async Task<ResultSuppressionListAdd> AddAsync( int listId, string email ) {
            var arry = new Dictionary<string, string> {
                { "EmailAddress", email },
                { "ListID", listId.ToString() }
            };
            return await _http.Value.PostAsync<ResultSuppressionListAdd>( SendloopAddress.SuppressionListAdd, arry );
        }
        #endregion
    }
}
