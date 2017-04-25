namespace Sendloop.Result {
    public class ResultBase {
        public bool Success { get; set; }
        public ErrorCode ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string[] ErrorFields { get; set; }
    }
}
