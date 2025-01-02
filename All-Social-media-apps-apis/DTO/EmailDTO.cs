using System.ComponentModel.DataAnnotations;

namespace All_Social_media_apps_apis.DTO
{
    public class EmailDTO
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
        public string Body { get; set; }
        public DateTime SentDate { get; set; }
        [MaxLength(500)]
        public string Attachments { get; set; }
    }
}
