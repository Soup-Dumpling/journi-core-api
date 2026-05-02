namespace Journi.CodingChallenge.Api.Models.Headphone
{
    public class GetHeadphonesRequest
    {
        public int PageSize { get; set; } = 50;
        public int Page { get; set; } = 1;
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Color { get; set; }
        public bool? Wireless { get; set; }
        public bool? Mic { get; set; }
    }
}
