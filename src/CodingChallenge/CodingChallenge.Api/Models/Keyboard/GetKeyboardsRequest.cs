namespace Journi.CodingChallenge.Api.Models.Keyboard
{
    public class GetKeyboardsRequest
    {
        public int PageSize { get; set; } = 50;
        public int Page { get; set; } = 1;
        public string Name { get; set; }
        public bool? Wireless { get; set; }
        public bool? IsMechanical { get; set; }
    }
}
