namespace BlazorEcommerce.Server.Services.EmailService
{
    public interface IEmailService
    {
        Task<ServiceResponse<int>> SendEmailLink(EmailDto request);
    }
}
