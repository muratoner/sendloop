using System;
using Sendloop.Param.Subscriber;

namespace Sendloop.Console {
    class Program {

        static readonly Lazy<SendloopManager> SendloopManager = new Lazy<SendloopManager>( () => new SendloopManager( "{YOUR-SENDLOOP-API-KEY}" ) );

        static void Main( string[] args ) {
            var res = SendloopManager.Value.Subscriber.Get( new ParamSubscriberGet {
                ListID = 1,
                EmailAddress = "mailaddress"
            } );
        }
    }
}
