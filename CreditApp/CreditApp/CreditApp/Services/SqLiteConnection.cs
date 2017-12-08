using CreditApp.Infrastructure.Data;
using SQLitePCL;

namespace CreditApp.Core.UWP.Services
{
    public class SqLiteConnection : ISqLiteConnection
    {
        public SqLiteConnection()
        {
            Connection = new SQLiteConnection(Constants.DbFileName);
        }

        public SQLiteConnection Connection { get; }
    }
}
