using QrCode.Application.Requests;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrCode.Application.Interfaces.Services
{
    public interface IStampService
    {
        public Task StampQrCodeAsync (UploadRequest request,string fullpath, int id);
    }
}
