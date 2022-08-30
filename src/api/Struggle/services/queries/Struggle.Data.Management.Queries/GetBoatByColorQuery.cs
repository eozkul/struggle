using AutoMapper;
using MediatR;
using Struggle.Data.Abstractions;
using Struggle.Data.Requests.Contracts;
using Struggle.Data.Requests.RequestQueries;
using Struggle.Entities;
namespace Struggle.Data.Management.Queries
{
    internal class GetBoatByColorQuery : IRequestHandler<GetBoatByColorRequest, BoatDto>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetBoatByColorQuery(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<BoatDto> Handle(GetBoatByColorRequest request, CancellationToken cancellationToken)
        {
            var repository = unitOfWork.GetRepository<Boat>();
            return await repository.Get<BoatDto>(f => f.Color == request.Color, cancellationToken);
        }
    }
}
