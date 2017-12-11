using System.Threading.Tasks;

namespace CreditApp.Infrastructure.Data.Repositories.Interfaces
{
    public interface IDatabaseRepository
    {
        Task CreateTables();
    }
}
