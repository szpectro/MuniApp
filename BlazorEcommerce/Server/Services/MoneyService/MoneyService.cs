using Newtonsoft.Json;


namespace BlazorEcommerce.Server.Services.MoneyService
{
    public class MoneyService : IMoneyService
    {
        private readonly DataContext _context;

        public MoneyService(DataContext context)
        {
            _context = context;
        }

        public async Task<Valores> GetValores()
        {                                     
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://mindicador.cl/api");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var Sresponse = JsonConvert.DeserializeObject<Valores>(responseBody);             
                       
            return (Sresponse);
        }
    }
}
