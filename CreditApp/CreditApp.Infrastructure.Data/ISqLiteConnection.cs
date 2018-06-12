using SQLite.Net;
using SQLite.Net.Async;

namespace CreditApp.Infrastructure.Data
{
    public interface ISqLiteConnection
    {
        SQLiteAsyncConnection Connection { get; }
    }
}
