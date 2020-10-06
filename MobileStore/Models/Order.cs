namespace MobileStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string User { get; set; }
        public string Address { get; set; } 
        public string ContactPhone { get; set; } 
        public int PhoneId { get; set; }
        public Phone Phone { get; set; }
    }
}