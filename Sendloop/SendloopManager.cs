namespace Sendloop {

    using Core;
    using Process.Campaign;
    using Process.SubcriberList;
    using Process.Subscriber;
    using Process.Account;

    public class SendloopManager {

        public Campaign Campaign { get; set; }
        public Subscriber Subscriber { get; set; }
        public SubscriberList SubscriberList { get; set; }
        public Process.System.System System { get; set; }
        public Account Account { get; set; }

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
        public SendloopManager( string apiKey, string subdomain )
        {
            SendloopInfo.ApiKey = apiKey;
            SendloopInfo.Subdomain = subdomain;

            #region Process
                Campaign = new Campaign();
                Subscriber = new Subscriber();
                SubscriberList = new SubscriberList();
                System = new Process.System.System();
                Account = new Account();
            #endregion
        }
    }
}
