namespace Sendloop.Extension {
    public static class StringExt {
        public static bool IsNotNullOrEmpty(this string value)
            => !string.IsNullOrEmpty(value);
    }
}
