using Sendloop.Enum;
using Sendloop.Param.Subscriber;
using Sendloop.Param.SubscriberList;

namespace Sendloop.Console {
    class Program {
        static void Main( string[] args ) {
            var res = new SendloopManager( "{YOUR-SENDLOOP-API-KEY}" );
            var console = res.SubscriberList.Get(new ParamSubscriberListGet {
                ListID = 5
            });
        }
    }
}
