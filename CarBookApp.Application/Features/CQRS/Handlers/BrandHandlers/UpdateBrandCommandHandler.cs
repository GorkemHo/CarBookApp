using CarBookApp.Application.Features.CQRS.Commands.BannerCommands;
using CarBookApp.Application.Features.CQRS.Commands.BrandCommands;
using CarBookApp.Application.Interfaces;
using CarBookApp.Domain.Entities;

namespace CarBookApp.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class UpdateBrandCommandHandler
    {
        private readonly IRepository<Brand> _repository;

        public UpdateBrandCommandHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateBrandCommand command)
        {
            var values = await _repository.GetByIdAsync(command.BrandID);
           values.Name = command.Name;
            await _repository.UpdateAsync(values);
        }
    }
}
