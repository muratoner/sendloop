namespace Sendloop.Result.Subscriber {
    public class ResultSubscriberImport : ResultBase {
        public int TotalImported { get; set; }
        public int TotalDuplicate { get; set; }
        public int TotalFailed { get; set; }
    }
}
