using AutoMapper;
using MediatR;
using Struggle.Data.Abstractions;
using Struggle.Data.Requests.Contracts;
using Struggle.Data.Requests.RequestQueries;
using Struggle.Entities;
namespace Struggle.Data.Management.Queries
{
    internal class GetBusByColorQuery : IRequestHandler<GetBusByColorRequest, BusDto>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetBusByColorQuery(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<BusDto> Handle(GetBusByColorRequest request, CancellationToken cancellationToken)
        {
            var repository = unitOfWork.GetRepository<Bus>();
            return await repository.Get<BusDto>(f => f.Color == request.Color, cancellationToken);
        }
    }
}
