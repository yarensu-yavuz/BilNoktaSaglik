namespace YarenSuYavuz2.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        public string requestid { get; set; }   
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}