using System.Threading.Tasks;
using CreditApp.Infrastructure.Data.Repositories.Interfaces;
using SQLiteAsyncConnection = SQLite.Net.Async.SQLiteAsyncConnection;

namespace CreditApp.Infrastructure.Data.Repositories
{
    public class DatabaseRepository : RepositoryBase, IDatabaseRepository
    {
        private readonly SQLiteAsyncConnection _db;

        public DatabaseRepository(ISqLiteConnection sqLiteConnection) : base(sqLiteConnection)
        {
            _db = sqLiteConnection.Connection;
        }

        public async Task CreateTables()
        {
            await _db.CreateTableAsync<Dto.Debtor>();
        }
    }
}
