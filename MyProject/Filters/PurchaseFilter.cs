namespace MyProject.Filters
{
    public class PurchaseFilter
    {
        public long? AccountId { get; set; }
        public long? OperationId { get; set; }
        public long? CompanyId { get; set; }
        public long? DocumentId { get; set; }
        public string DocumentNumber { get; set; }
    }
}
