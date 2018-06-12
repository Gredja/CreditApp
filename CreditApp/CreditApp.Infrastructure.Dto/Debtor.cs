using CreditApp.Infrastructure.Dto.Base;
using SQLite.Net.Attributes;

namespace CreditApp.Infrastructure.Dto
{
    [Table("DEBTORS")]
    public class Debtor : BaseModel
    {
        public string Name { get; set; }
    }
}
