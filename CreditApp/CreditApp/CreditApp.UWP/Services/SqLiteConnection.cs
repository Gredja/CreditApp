using System;
using System.IO;
using CreditApp.Core.UWP;
using CreditApp.Infrastructure.Data;
using SQLite.Net;
using SQLite.Net.Async;
using SQLite.Net.Platform.WinRT;

namespace CreditApp.UWP.Services
{
   public class SqLiteConnection : ISqLiteConnection
    {
        public SqLiteConnection()
        {
            var dbPath = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, Constants.DbFileName);

            var connectionFactory = new Func<SQLiteConnectionWithLock>(() =>
                new SQLiteConnectionWithLock(new SQLitePlatformWinRT(),new SQLiteConnectionString(dbPath, false)));

            Connection =  new SQLiteAsyncConnection(connectionFactory);
        }

        public SQLiteAsyncConnection Connection { get; }
    }
}
