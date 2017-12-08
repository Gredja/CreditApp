using CreditApp.Infrastructure.Dto.Base;

namespace CreditApp.Infrastructure.Dto
{
    public class Credit : BaseModel
    {
        public string DebtorId { get; set; }

        public string Currency { get; set; }

        public int Amount { get; set; }

        public bool Active { get; set; } = true;

        public string Comment { get; set; }
    }
}
