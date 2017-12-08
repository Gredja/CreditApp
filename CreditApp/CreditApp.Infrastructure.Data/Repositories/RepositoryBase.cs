using SQLitePCL;

namespace CreditApp.Infrastructure.Data.Repositories
{
    public abstract class RepositoryBase
    {
        protected readonly SQLiteConnection Database;

        protected RepositoryBase(ISqLiteConnection sqLiteConnection)
        {
            Database = sqLiteConnection.Connection;
        }
    }
}
