using MediatR;
namespace Struggle.Data.Requests.RequestCommands
{
    public class DeleteBusByIdRequest : IRequest<bool>
    {
        public DeleteBusByIdRequest(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }

    }
}
