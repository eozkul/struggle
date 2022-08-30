using MediatR;
using Struggle.Data.Requests.Contracts;

namespace Struggle.Data.Requests.RequestCommands
{
    public class UpdateBusRequest : IRequest<bool>
    {
        public UpdateBusRequest(BusDto data)
        {
            Data = data;
        }

        public BusDto Data { get; }
    }
}
