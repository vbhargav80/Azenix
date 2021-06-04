namespace Azenix.Model
{
    public class LogEvent
    {
        public string ClientIp { get; set; }
        public string Timestamp { get; set; }
        public string Uri { get; set; }
        public string HttpStatusCode { get; set; }
        public string NumBytes { get; set; }
        public string UserAgent { get; set; }
    }
}
