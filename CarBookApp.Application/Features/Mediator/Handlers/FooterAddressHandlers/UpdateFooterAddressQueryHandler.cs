using CarBookApp.Application.Features.Mediator.Commands.FeatureCommands;
using CarBookApp.Application.Features.Mediator.Commands.FooterAddressCommands;
using CarBookApp.Application.Interfaces;
using CarBookApp.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApp.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class UpdateFooterAddressQueryHandler : IRequest<UpdateFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;

        public UpdateFooterAddressQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.FooterAddressID);
            values.Phone = request.Phone;
            values.Email = request.Email;
            values.Address = request.Address;
            values.Description = request.Description;
            await _repository.UpdateAsync(values);
        }
    }
}
