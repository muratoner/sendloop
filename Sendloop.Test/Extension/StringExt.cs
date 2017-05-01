namespace Sendloop.Extension {
    internal static class StringExt {
        internal static bool IsNotNullOrEmpty(this string value)
            => !string.IsNullOrEmpty(value);
    }
}
