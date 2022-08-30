using MediatR;
using Struggle.Data.Requests.Contracts;
namespace Struggle.Data.Requests.RequestCommands
{
    public class UpdateCarRequest : IRequest<bool>
    {
        public UpdateCarRequest(UpdateCarDto data)
        {
            Data = data;
        }
        public UpdateCarDto Data { get; }
    }
}
