using AutoMapper;
using MediatR;
using Struggle.Data.Abstractions;
using Struggle.Data.Requests.RequestCommands;
using Struggle.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struggle.Data.Management.Commands
{
    internal class DeleteBusCommand:IRequestHandler<DeleteBusByIdRequest,bool>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public DeleteBusCommand(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<bool> Handle(DeleteBusByIdRequest request, CancellationToken cancellationToken)
        {
            var repository = unitOfWork.GetRepository<Bus>();
            var entity = await repository.Get<Bus>(x =>!x.IsDeleted&& x.Id == request.Id, cancellationToken);
            if (entity == null)
            {
                return false;
            }
            repository.Delete(entity);
            var result = await unitOfWork.SaveChanges(cancellationToken);
            return result > 0;
        }
    }
}
