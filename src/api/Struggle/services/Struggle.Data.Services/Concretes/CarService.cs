using MediatR;
using Struggle.Common;
using Struggle.Data.Requests.Contracts;
using Struggle.Data.Requests.RequestCommands;
using Struggle.Data.Requests.RequestQueries;
using Struggle.Data.Services.Abstractions;

namespace Struggle.Data.Services.Concretes
{
    internal class CarService : ICarService
    {
        private readonly IMediator mediator;
        public CarService(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public Task<bool> DeleteCarById(Guid id, CancellationToken cancellationToken)
        {
            return mediator.Send(new DeleteCarByIdRequest(id), cancellationToken);
        }

        public Task<CarDto> GetCarByColor(Color color, CancellationToken cancellationToken)
        {
            return mediator.Send(new GetCarByColorRequest(color), cancellationToken);
        }

        public Task<bool> UpdateCar(UpdateCarDto data, CancellationToken cancellationToken)
        {
            return mediator.Send(new UpdateCarRequest(data), cancellationToken);
        }
    }
}
