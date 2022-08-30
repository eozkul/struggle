using Struggle.Common;
using Struggle.Data.Requests.Contracts;
namespace Struggle.Data.Services.Abstractions
{
    public interface IBusService
    {
        Task<BusDto> GetBusByColor(Color color, CancellationToken cancellationToken);
        Task<bool> UpdateBus(BusDto data, CancellationToken cancellationToken);
        Task<bool> DeleteBusById(Guid id, CancellationToken cancellationToken);
    }
}
