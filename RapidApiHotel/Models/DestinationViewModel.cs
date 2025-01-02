namespace RapidApiHotel.Models
{
    public class DestinationViewModel
    {
        public bool status { get; set; }
        public string message { get; set; }
        public long timestamp { get; set; }
        public List<Destination> data { get; set; }


        public class Destination
        {
            public string dest_id { get; set; }
            public string search_type { get; set; }
            public string type { get; set; }
            public string region { get; set; }
            public int? hotels { get; set; }
            public string roundtrip { get; set; }
            public string dest_type { get; set; }
            public string lc { get; set; }
            public double? longitude { get; set; }
            public double? latitude { get; set; }
            public string label { get; set; }
            public string city_name { get; set; }
            public string country { get; set; }
            public string image_url { get; set; }
            public string cci { get; set; }
            public int? nr_hotels { get; set; }
            public string name { get; set; }
            public object city_ufi { get; set; }
        }

    }
}
