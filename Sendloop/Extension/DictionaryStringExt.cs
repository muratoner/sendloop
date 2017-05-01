using System.Collections.Generic;

namespace Sendloop.Extension {
    internal static class DictionaryStringExt {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        internal static void Add( this Dictionary<string, string> model, string key, string value )
            => model.Add( key, value );

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        internal static void AddWithCondition(this Dictionary<string, string> model, bool condition, string key, object value)
        {
            if(condition)
                model.Add(key, value.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        internal static void IfIsNotNullOrEmptyThenAdd(this Dictionary<string, string> model, string key, string value)
        {
            if( value.IsNotNull() && value.Trim().IsNotNullOrEmpty())
                model.Add( key, value );
        }
    }
}
