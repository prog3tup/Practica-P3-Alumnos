using RestSharp;
using System.Text.Json;

namespace Demo_Linq
{
    public class JuegosService
    {

        private static readonly JuegosService instance = new JuegosService();
        private readonly RestClient _client;

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static JuegosService()
        {
        }

        private JuegosService()
        {
            _client = new RestClient("https://www.cheapshark.com");
        }

        public static JuegosService Instance
        {
            get
            {
                return instance;
            }
        }



        public async Task<List<Juego>> GetOfertasAsync()
        {
            var request = new RestRequest($"api/1.0/deals?storeID=1&upperPrice=15");
            var response = await _client.ExecuteGetAsync(request);
            if (!response.IsSuccessful)
            {
                //Logic for handling unsuccessful response
            }
            return JsonSerializer.Deserialize<List<Juego>>(response.Content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
       
    }
}
