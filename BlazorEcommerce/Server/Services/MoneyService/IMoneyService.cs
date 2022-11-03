namespace BlazorEcommerce.Server.Services.MoneyService
{
    public interface IMoneyService
    {
        Task<Valores> GetValores();
    }
}
