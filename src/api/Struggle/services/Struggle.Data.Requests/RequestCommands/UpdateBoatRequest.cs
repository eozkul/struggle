using MediatR;
using Struggle.Data.Requests.Contracts;

namespace Struggle.Data.Requests.RequestCommands
{
    public class UpdateBoatRequest:IRequest<bool>
    {
        public UpdateBoatRequest(BoatDto data)
        {
            Data = data;
        }

        public BoatDto Data { get; }
    }
}
