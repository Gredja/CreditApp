using System.Threading.Tasks;
using CreditApp.Infrastructure.Data.Repositories.Interfaces;

namespace CreditApp.Infrastructure.Data.Repositories
{
    public class DatabaseRepository : RepositoryBase, IDatabaseRepository
    {
        public DatabaseRepository(ISqLiteConnection sqLiteConnection) : base(sqLiteConnection) { }

        public Task CreateDatabaseAsync()
        {
           return Database.CreateTablesAsync(typeof(Dto.Debtor));
        }
    }
}
