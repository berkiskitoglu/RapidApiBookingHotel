namespace RapidApiHotel.Models
{
    public class HotelViewModel
    {

        public bool status { get; set; }
        public string message { get; set; }
        public long timestamp { get; set; }

        public Data data { get; set; }

        public class Data
        {
            public List<Hotel> hotels { get; set; }
        }

        public class Hotel
        {
            public string hotel_id { get; set; }
            public string accessibilityLabel { get; set; }
            public Property property { get; set; }
        }

        public class Property
        {
            public string[] photoUrls { get; set; }
            public string name { get; set; }
            public string currency { get; set; }
            public string reviewScore { get; set; }
            public string reviewScoreWord { get; set; }
            public PriceBreakdown priceBreakdown { get; set; }
        }

        public class PriceBreakdown
        {
            public GrossPrice grossPrice { get; set; }
            public StrikeThroughPrice strikethroughPrice { get; set; }
        }

        public class GrossPrice
        {
            public double value { get; set; }
            public string currency { get; set; }

        }

        public class StrikeThroughPrice
        {
            public double value { get; set; }
            public string currency { get; set; }
        }

    }
}
