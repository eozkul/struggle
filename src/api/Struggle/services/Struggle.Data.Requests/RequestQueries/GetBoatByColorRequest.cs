using Struggle.Data.Requests.Contracts;
using MediatR;
using Struggle.Common;

namespace Struggle.Data.Requests.RequestQueries
{
    public class GetBoatByColorRequest : IRequest<BoatDto>
    {
        public GetBoatByColorRequest(Color color)
        {
            Color = color;
        }
        public Color Color { get; }
    }
}