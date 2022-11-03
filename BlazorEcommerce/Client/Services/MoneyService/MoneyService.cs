using BlazorEcommerce.Client.Pages.Admin;
using BlazorEcommerce.Shared;

namespace BlazorEcommerce.Client.Services.MoneyService
{
    public class MoneyService : IMoneyService
    {
        private readonly HttpClient _http;

        public MoneyService(HttpClient http)
        {
            _http = http;
        }
        public Valores Valorez { get; set; } = new Valores();

        public async Task<Valores> GetValores()
        {
                      
            var result = await _http.GetFromJsonAsync<Valores>("api/money");
            return result;

        }
    }
}
