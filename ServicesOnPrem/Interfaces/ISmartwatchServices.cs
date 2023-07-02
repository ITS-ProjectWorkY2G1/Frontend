using ModelsOnPrem;

namespace ServicesOnPrem.Services
{
    public interface ISmartwatchServices
    {
        Task<List<SmartwatchesOnPrem>> GetSmartwatchesOnPremAsync();
    }
}
