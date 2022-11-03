namespace BlazorEcommerce.Client.Services.MoneyService
{
    public interface IMoneyService
    {
        Valores Valorez { get; set; }
        Task<Valores> GetValores();

        
    }
}
