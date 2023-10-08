namespace DevFreela.Infrastructure.Services.Interfaces
{
    public interface IFileStorageService
    {
        void UploudFile(byte[] bytes, string fileName);
    }
}
