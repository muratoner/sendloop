namespace Sendloop.Extension {
    internal static class BoolExt
    {
        public static int ToBinary(this bool value)
            => value ? 1 : 0;
    }
}
