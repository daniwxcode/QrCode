using IronBarCode;

using QrCode.Application.Extensions;
using QrCode.Application.Interfaces.Repositories;
using QrCode.Application.Interfaces.Services;
using QrCode.Application.Requests;
using QrCode.Domain.Entities.Misc;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrCode.Infrastructure.Services
{
    public class StampService : IStampService
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        public StampService (IUnitOfWork<int> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task StampQrCodeAsync (UploadRequest request,string fullPath, int TypeDoc)
        {
            
            var type = await _unitOfWork.Repository<DocumentType>().GetByIdAsync(TypeDoc);
                GeneratedBarcode QRWithLogo = BarcodeWriter.CreateBarcode(request.FileName, BarcodeWriterEncoding.QRCode);
                QRWithLogo.ResizeTo((int)type.Size*5, (int)type.Size).SetMargins(10).ChangeBarCodeColor(Color.BlueViolet);
                QRWithLogo.StampToExistingPdfPage(fullPath, (int)type.PositionX, (int)type.PositionY,Password:request.FileName);

            
        }
    }
}
