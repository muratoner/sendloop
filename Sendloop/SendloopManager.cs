using Sendloop.Process.TransactionEmail;

namespace Sendloop {

    using Core;
    using Process.Campaign;
    using Process.SubcriberList;
    using Process.Subscriber;
    using Process.Account;
    using Process.SuppressionList;

    public class SendloopManager {

        public Campaign Campaign { get; set; }
        public Subscriber Subscriber { get; set; }
        public SubscriberList SubscriberList { get; set; }
        public Process.System.System System { get; set; }
        public Account Account { get; set; }
        public SuppressionList SuppressionList { get; set; }
        //public TransactionEmail TransactionEmail { get; set; }

        /// <summary>
        /// Required api key parameter for correct api communication.
        /// You want take a api key then visit this url: http://[your-account].sendloop.com/settings/api/
        /// <param name="apiKey">
        /// Give an api key.
        /// <example>
        /// 0000-0000-0000-0000-0000-0000-0000-0000
        /// </example>
        /// </param>
        /// </summary>
        public SendloopManager( string apiKey )
        {
            SendloopInfo.ApiKey = apiKey;

            #region Process
            Campaign = new Campaign();
            Subscriber = new Subscriber();
            SubscriberList = new SubscriberList();
            System = new Process.System.System();
            Account = new Account();
            SuppressionList = new SuppressionList();
            //TransactionEmail = new TransactionEmail();
            #endregion
        }

        /// <summary>
        /// Required api key parameter for correct api communication.
        /// You want take a api key then visit this url: http://[your-account].sendloop.com/settings/api/
        /// <param name="apiKey">
        /// Give an api key.
        /// <example>
        /// 0000-0000-0000-0000-0000-0000-0000-0000
        /// </example>
        /// </param>
        /// <param name="subdomain">
        /// http://[subdomain].sendloop.com/settings/api/
        /// </param>
        /// </summary>
        public SendloopManager( string apiKey, string subdomain ) : this(apiKey)
        {
            SendloopInfo.Subdomain = subdomain;
        }
    }
}
