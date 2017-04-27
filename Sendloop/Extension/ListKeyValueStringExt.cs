using System.Collections.Generic;

namespace Sendloop.Extension {
    public static class ListKeyValueStringExt {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void Add( this List<KeyValuePair<string, string>> model, string key, string value )
            => model.Add( new KeyValuePair<string, string>( key, value ) );

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void IfIsNotNullOrEmptyThenAdd(this List<KeyValuePair<string, string>> model, string key, string value)
        {
            if( value.IsNotNull() && value.Trim().IsNotNullOrEmpty())
                model.Add( new KeyValuePair<string, string>( key, value ) );
        }
    }
}
