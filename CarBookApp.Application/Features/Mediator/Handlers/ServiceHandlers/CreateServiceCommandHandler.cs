
using CarBookApp.Application.Features.Mediator.Commands.ServiceCommands;
using CarBookApp.Application.Interfaces;
using CarBookApp.Domain.Entities;
using MediatR;


namespace CarBookApp.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand>
    {
        private readonly IRepository<Service> _repository;

        public CreateServiceCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Service
            {
                Description = request.Description,
                IconUrl = request.IconUrl,
                Title = request.Title,
            });
        }
    }
}
