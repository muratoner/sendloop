using Sendloop.Extension;

namespace Sendloop {

    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    using Flurl.Http;
    using Newtonsoft.Json;

    using Core;

    internal class HttpClientManager {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="url"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        internal async Task<string> PostAsync( string url, Dictionary<string, string> model = null ) {
            if ( model.IsNull() )
                model = new Dictionary<string, string>();

            model.Add("APIKey", SendloopInfo.ApiKey );
            var res = await url.PostAsync( new FormUrlEncodedContent( model ) );
            return await res.Content.ReadAsStringAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="url"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        internal async Task<TResult> PostAsync<TResult>( string url, Dictionary<string, string> model = null ) {
            if ( model.IsNull() )
                model = new Dictionary<string, string>();

            model.Add("APIKey", SendloopInfo.ApiKey );
            var res = await url.PostAsync( new FormUrlEncodedContent( model ) );
            return JsonConvert.DeserializeObject<TResult>( await res.Content.ReadAsStringAsync() );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="url"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        internal TResult Post<TResult>( string url, Dictionary<string, string> model )
            => PostAsync<TResult>( url, model ).GetAwaiter().GetResult();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="url"></param>
        /// <returns></returns>
        internal TResult Post<TResult>( string url )
            => PostAsync<TResult>( url ).GetAwaiter().GetResult();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="xml"></param>
        /// <returns></returns>
        internal TResult Deserialize<TResult>( string xml ) {
            var serializer = new XmlSerializer( typeof( TResult ) );
            object result;

            using ( TextReader reader = new StringReader( xml ) ) {
                result = serializer.Deserialize( reader );
            }

            return (TResult)result;
        }
    }
}
