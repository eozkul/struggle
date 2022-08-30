using Struggle.Data.Requests.Contracts;
using MediatR;
using Struggle.Common;

namespace Struggle.Data.Requests.RequestQueries
{
    public class GetBusByColorRequest : IRequest<BusDto>
    {
        public GetBusByColorRequest(Color color)
        {
            Color = color;
        }
        public Color Color { get; }
    }
}