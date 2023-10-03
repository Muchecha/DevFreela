using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Services.Interfaces
{
    public interface IFileStorageService
    {
        void UploudFile(byte[] bytes, string fileName);
    }
}
