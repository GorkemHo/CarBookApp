using CarBookApp.Application.Features.Mediator.Commands.ServiceCommands;
using CarBookApp.Application.Interfaces;
using CarBookApp.Domain.Entities;
using MediatR;

namespace CarBookApp.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class RemoveServiceCommandHandler :IRequestHandler<RemoveServiceCommand>
    {
        private readonly IRepository<Service> _repository;

        public RemoveServiceCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveServiceCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
