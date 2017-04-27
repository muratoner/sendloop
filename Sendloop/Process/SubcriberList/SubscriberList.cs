using System;
using System.Threading.Tasks;

namespace Sendloop.Process.SubcriberList {

    using Result.SubscriberList;

    public class SubscriberList {
        private Lazy<HttpClientManager> Http { get; } = new Lazy<HttpClientManager>( () => new HttpClientManager() );

        #region GetList
        /// <summary>
        /// Returns the list of all active subscriber lists inside the Sendloop account.
        /// </summary>
        /// <returns></returns>
        public ResultSubscriberListGetList GetList()
            => Http.Value.Post<ResultSubscriberListGetList>( SendloopAddress.SubscriberListGetList );

        /// <summary>
        /// Returns the list of all active subscriber lists inside the Sendloop account.
        /// </summary>
        /// <returns></returns>
        public async Task<ResultSubscriberListGetList> GetListAsync()
            => await Http.Value.PostAsync<ResultSubscriberListGetList>( SendloopAddress.SubscriberListGetList );
        #endregion
    }
}
