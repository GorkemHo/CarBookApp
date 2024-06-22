
using CarBookApp.Application.Features.Mediator.Commands.SocialMediaCommands;
using CarBookApp.Application.Interfaces;
using CarBookApp.Domain.Entities;
using MediatR;


namespace CarBookApp.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class CreateSocialMediaCommandHandler : IRequestHandler<CreateSocialMediaCommand>
    {
        private readonly IRepository<SocialMedia> _repository;

        public CreateSocialMediaCommandHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new SocialMedia
            {
                Icon = request.Icon,
                Name = request.Name,
                Url = request.Url,
            });
        }
    }
}
