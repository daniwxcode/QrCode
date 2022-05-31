using QrCode.Application.Responses.Identity;
using QrCode.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using QrCode.Application.Interfaces.Chat;
using QrCode.Application.Models.Chat;

namespace QrCode.Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> message);

        Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
    }
}