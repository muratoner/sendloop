using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sendloop.Param.TransactionEmail;
using Sendloop.Result.TransactionEmail;

namespace Sendloop.Process.TransactionEmail {
    public class TransactionEmail {
        private Lazy<HttpClientManager> Http => new Lazy<HttpClientManager>( () => new HttpClientManager() );

        #region Send Transaction Email
        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public ResultTransactionEmailSend Send( ParamTransactionEmailSend param )
            => SendAsync( param ).GetAwaiter().GetResult();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<ResultTransactionEmailSend> SendAsync( ParamTransactionEmailSend param ) {
            var arry = new Dictionary<string, string> {
                { nameof(param.From), param.From },
                { nameof(param.FromName), param.FromName },
                { nameof(param.ReplyTo), param.ReplyTo },
                { nameof(param.ReplyToName), param.ReplyToName },
                { nameof(param.To), param.To },
                { nameof(param.Subject), param.Subject },
                { nameof(param.TextBody), param.TextBody },
                { nameof(param.HtmlBody), param.HtmlBody }
            };
            return await Http.Value.PostAsync<ResultTransactionEmailSend>( SendloopAddress.TransactionSendEmail, arry );
        }
        #endregion

        #region Delivery Status Check

        #endregion
    }
}
