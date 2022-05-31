using AutoMapper;
using QrCode.Application.Interfaces.Chat;
using QrCode.Application.Models.Chat;
using QrCode.Infrastructure.Models.Identity;

namespace QrCode.Infrastructure.Mappings
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<BlazorHeroUser>>().ReverseMap();
        }
    }
}