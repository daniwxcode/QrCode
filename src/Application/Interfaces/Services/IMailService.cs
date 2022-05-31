using QrCode.Application.Requests.Mail;
using System.Threading.Tasks;

namespace QrCode.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}