using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiHotel.Models;

namespace RapidApiHotel.Controllers
{
    public class BookingController : Controller
    {
        private readonly string _apiKey = "9943a13e27msh50b639ae65379aap1c594bjsn612ea0987684";
        private readonly string _apiHost = "booking-com15.p.rapidapi.com";
        private readonly HttpClient _httpClient;

        public BookingController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HotelList()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> HotelList(string city, string arrival_date, string departure_date, string adults)
        {
            try
            {
                var destinations = await GetHotelDestinations(city.ToLower());
                var selectedDestination = GetRandomDestination(destinations);
                var hotels = await SearchHotels(selectedDestination, arrival_date, departure_date, adults);

                return View(hotels);
            }
            catch (Exception ex)
            {
                // Log error
                return View("Error");
            }
        }
        private DestinationViewModel.Destination GetRandomDestination(List<DestinationViewModel.Destination> destinations)
        {
            var random = new Random();
            var randomIndex = random.Next(0, destinations.Count);
            return destinations[randomIndex];
        }

        private async Task<HotelViewModel.Data> SearchHotels(DestinationViewModel.Destination destination, string arrivalDate, string departureDate, string adults)
        {
            var request = CreateApiRequest(
                $"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?dest_id={destination.dest_id}" +
                $"&search_type={destination.search_type}&arrival_date={arrivalDate}&departure_date={departureDate}" +
                $"&adults={adults}&children_age=0%2C17&room_qty=1&page_number=1&units=metric&temperature_unit=c" +
                $"&languagecode=en-us&currency_code=USD"
            );

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            var result = JsonConvert.DeserializeObject<HotelViewModel>(content);
            return result.data;
        }

        [HttpGet]
        public async Task<List<DestinationViewModel.Destination>> GetHotelDestinations(string query)
        {
            var request = CreateApiRequest(
                $"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchDestination?query={query}"
            );

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<DestinationViewModel>(content);
            return result.data;
        }

        private HttpRequestMessage CreateApiRequest(string uri)
        {
            return new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(uri),
                Headers =
                {
                    { "x-rapidapi-key", _apiKey },
                    { "x-rapidapi-host", _apiHost },
                }
            };
        }
    }
}

