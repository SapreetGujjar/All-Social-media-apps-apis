namespace All_Social_media_apps_apis.Models
{
    public class Gmail
    {
        public int Id { get; set; }
        public string? To { get; set; }
        public string? From { get; set; }
        public string? CC { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
        public DateTime? SentDate { get; set; }
        public string? Attachments { get; set; }
    }
}
