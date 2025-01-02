using System.ComponentModel.DataAnnotations;

namespace All_Social_media_apps_apis.DTO
{
    public class EmailDTO
    {
        public string? Sender { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
        public DateTime? SentDate { get; set; }
    }
}
