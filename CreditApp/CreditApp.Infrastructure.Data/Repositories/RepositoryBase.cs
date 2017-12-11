using SQLite.Net.Async;

namespace CreditApp.Infrastructure.Data.Repositories
{
    public abstract class RepositoryBase
    {
        protected readonly SQLiteAsyncConnection Database;

        protected RepositoryBase(ISqLiteConnection sqLiteConnection)
        {
            Database = sqLiteConnection.Connection;
        }
    }
}
