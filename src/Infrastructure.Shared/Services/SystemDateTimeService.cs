using QrCode.Application.Interfaces.Services;
using System;

namespace QrCode.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}