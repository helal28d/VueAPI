
 
using VueAPI.DTOs;

namespace VueAPI.Services
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
        void SendCodeEmail(string to, string sub, string body);

    }
}
