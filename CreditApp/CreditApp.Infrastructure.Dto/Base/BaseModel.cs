using SQLite.Net.Attributes;

namespace CreditApp.Infrastructure.Dto.Base
{
    public class BaseModel
    {
        [PrimaryKey, AutoIncrement]
        public string Id { get; set; }
    }
}
