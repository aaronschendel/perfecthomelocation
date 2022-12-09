using Newtonsoft.Json;

namespace PerfectHomeLocation.Services
{
    public class MapsService : IMapsService
    {
        private readonly HttpClient _mapsApiHttpClient;
        private readonly string _baseAddress = "https://maps.googleapis.com/maps/api/";
        private readonly string _apiKey;

        public MapsService(string apiKey)
        {
            _mapsApiHttpClient = new HttpClient { BaseAddress = new Uri("https://maps.googleapis.com/maps/api/") };
            _apiKey = apiKey;
        }

        public async Task<SearchByTextResponse> SearchForPlace(string searchString)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, new Uri($"{_baseAddress}place/findplacefromtext/json?input={searchString}&inputtype=textquery&key={_apiKey}"));
            request.Headers.TryAddWithoutValidation("Accept", "application/json");

            //var result = await _mapsApiHttpClient.GetAsync();
            HttpResponseMessage response = await _mapsApiHttpClient.SendAsync(request);
            
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            Console.WriteLine(response.Content);

            var stringResponse = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<SearchByTextResponse>(stringResponse);
        }
    }
}
