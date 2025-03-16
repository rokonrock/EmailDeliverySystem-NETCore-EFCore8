namespace EmailDeliverySystem.API.Models
{
    /*
    public class EmailRequest
    {
        public int Id { get; set; }
        public string RecipientEmail { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public string Status { get; set; } = "Pending"; // Pending, Sent, Failed
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
    */

    public class EmailRequest
    {
        public int Id { get; set; }
        public string To { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public EmailStatus Status { get; set; }
        public DateTime SentDate { get; set; }
    }

    public enum EmailStatus
    {
        Pending,
        Sent,
        Failed
    }

}
