using System;

namespace RuslanPR_Library.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }

    public enum OrderStatus
    {
        Pending,
        InProcess,
        Completed,
        Canceled
    }
}