using System.Threading.Tasks;

namespace MyBlogApp.Application.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
