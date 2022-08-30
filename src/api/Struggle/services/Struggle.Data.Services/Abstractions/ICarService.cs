using Struggle.Common;
using Struggle.Data.Requests.Contracts;
namespace Struggle.Data.Services.Abstractions
{
    public interface ICarService
    {
        Task<CarDto> GetCarByColor(Color color, CancellationToken cancellationToken);
        Task<bool> UpdateCar(UpdateCarDto data, CancellationToken cancellationToken);
        Task<bool> DeleteCarById(Guid id, CancellationToken cancellationToken);
    }
}
