using QrCode.Application.Models.Chat;
using QrCode.Application.Responses.Identity;
using QrCode.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using QrCode.Application.Interfaces.Chat;

namespace QrCode.Client.Infrastructure.Managers.Communication
{
    public interface IChatManager : IManager
    {
        Task<IResult<IEnumerable<ChatUserResponse>>> GetChatUsersAsync();

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> chatHistory);

        Task<IResult<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string cId);
    }
}