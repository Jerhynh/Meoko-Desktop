namespace NyaaNet.Models
{
    public class NyaaPost
    {
        public int id { get; set; }
        public string? title { get; set; }
        public string? category { get; set; }
        public string? uploaded { get; set; }
        public int seeders { get; set; }
        public int leechers { get; set; }
        public int completed { get; set; }
        public string? size { get; set; }
        public string? file { get; set; }
        public string? link { get; set; }
        public string? magnet { get; set; }
    }
}
