using CreditApp.Domain.Services.Services.Interfaces;
using CreditApp.Infrastructure.Data.Repositories.Interfaces;

namespace CreditApp.Domain.Services.Services
{
    public class DbService : IDbService
    {
        private readonly IDatabaseRepository _dbDatabaseRepository;

        public DbService(IDatabaseRepository dbDatabaseRepository)
        {
            _dbDatabaseRepository = dbDatabaseRepository;
        }

        public void ConfigureDb()
        {
            _dbDatabaseRepository.CreateTables();
        }
    }
}
