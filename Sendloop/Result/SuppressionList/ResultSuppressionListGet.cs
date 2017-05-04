namespace Sendloop.Result.SuppressionList {

    using Model.SuppressionList;

    public class ResultSuppressionListGet : ResultBase {
        public SuppressionListItem[] SuppressionItem { get; set; }
    }
}
