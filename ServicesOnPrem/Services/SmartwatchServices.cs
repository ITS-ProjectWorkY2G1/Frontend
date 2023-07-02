using Microsoft.EntityFrameworkCore;
using ModelsOnPrem;
namespace ServicesOnPrem.Services
{
    public class SmartwatchServices : ISmartwatchServices
    {
        private readonly PostgresContext _context;
        public SmartwatchServices(PostgresContext context)
        {
            _context = context;
        }

        public async Task<List<SmartwatchesOnPrem>> GetSmartwatchesOnPremAsync()
        {
            return await _context._smartwatchesOnPrem.ToListAsync();
        }
    }
}
