using System.ComponentModel.DataAnnotations;

namespace All_Social_media_apps_apis.Models
{
    public class Emails
    {
        public int Id { get; set; } 
        public string? Sender { get; set; }
        public string? Recipient { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; } // Email body content
        public DateTime? SentDate { get; set; } // Date the email was sent
        public string? Attachments { get; set; }
    }
}
