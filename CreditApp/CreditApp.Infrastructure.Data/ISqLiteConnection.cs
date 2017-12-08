using SQLitePCL;

namespace CreditApp.Infrastructure.Data
{
    public interface ISqLiteConnection
    {
        SQLiteConnection Connection { get; }
    }
}
