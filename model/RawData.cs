namespace GraphQLApi.Models
{
    public class RawData
    {
        public string Id { get; set; }
        public DateTime OpenTime { get; set; }
        public double Open { get; set; }
        public double Close { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public string SymbolName { get; set; }

    }
}