using System.ComponentModel.DataAnnotations;

namespace All_Social_media_apps_apis.Models
{
    public class Emails
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        [MaxLength(255)]
        public string Sender { get; set; }
        [Required]
        [MaxLength(255)]
        public string Recipient { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Body { get; set; } // Email body content
        public DateTime SentDate { get; set; } // Date the email was sent
        [MaxLength(500)]
        public string Attachments { get; set; }
    }
}
