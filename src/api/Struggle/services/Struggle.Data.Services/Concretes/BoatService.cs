using MediatR;
using Struggle.Common;
using Struggle.Data.Requests.Contracts;
using Struggle.Data.Requests.RequestCommands;
using Struggle.Data.Requests.RequestQueries;
using Struggle.Data.Services.Abstractions;
namespace Struggle.Data.Services.Concretes
{
    internal class BoatService : IBoatService
    {
        private readonly IMediator mediator;

        public BoatService(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public Task<bool> DeleteBoatById(Guid id, CancellationToken cancellationToken)
        {
            return mediator.Send(new DeleteBoatByIdRequest(id), cancellationToken);
        }

        public Task<BoatDto> GetBoatByColor(Color color, CancellationToken cancellationToken)
        {
            return mediator.Send(new GetBoatByColorRequest(color), cancellationToken);
        }

        public Task<bool> UpdateBoat(BoatDto data, CancellationToken cancellationToken)
        {
            return mediator.Send(new UpdateBoatRequest(data), cancellationToken);
        }
    }
}
