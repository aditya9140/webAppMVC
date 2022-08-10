namespace WebAppMVCTask.Models
{
    public class Orders
    {
        public int OrderId { get; set; }
        public string? OrderName { get; set; }
        public string? OrderNo { get; set; }
        public decimal Discount { get; set; }
        public DateTime Created { get; set; }
    }
}


