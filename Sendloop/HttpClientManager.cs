namespace Sendloop {

    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Xml.Serialization;
    using Flurl.Http;
    using Newtonsoft.Json;

    internal class HttpClientManager {
        internal async Task<TResult> PostAsync<TResult, TModel>( string url, TModel model ) {
            var res = await url.PostAsync(new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)model));
            return JsonConvert.DeserializeObject<TResult>(await res.Content.ReadAsStringAsync());
        }

        internal TResult Post<TResult, TModel>( string url, TModel model ) {
            var res = url.PostAsync(new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)model));
            var resWaiter = res.GetAwaiter();
            var resResult = resWaiter.GetResult();
            var content = resResult.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            return JsonConvert.DeserializeObject<TResult>(content);
        }

        internal TResult Deserialize<TResult>(string xml) {
            var serializer = new XmlSerializer(typeof(TResult));
            object result;

            using (TextReader reader = new StringReader(xml))
            {
                result = serializer.Deserialize(reader);
            }

            return (TResult)result;
        }
    }
}
