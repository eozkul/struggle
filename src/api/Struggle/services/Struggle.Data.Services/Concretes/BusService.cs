using MediatR;
using Struggle.Common;
using Struggle.Data.Requests.Contracts;
using Struggle.Data.Requests.RequestCommands;
using Struggle.Data.Requests.RequestQueries;
using Struggle.Data.Services.Abstractions;
namespace Struggle.Data.Services.Concretes
{
    internal class BusService : IBusService
    {
        private readonly IMediator mediator;

        public BusService(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public Task<bool> DeleteBusById(Guid id, CancellationToken cancellationToken)
        {
            return mediator.Send(new DeleteBusByIdRequest(id), cancellationToken);
        }

        public Task<BusDto> GetBusByColor(Color color, CancellationToken cancellationToken)
        {
            return mediator.Send(new GetBusByColorRequest(color), cancellationToken);
        }

        public Task<bool> UpdateBus(BusDto data, CancellationToken cancellationToken)
        {
            return mediator.Send(new UpdateBusRequest(data), cancellationToken);
        }
    }
}
