﻿using CarBookApp.Application.Features.Mediator.Commands.FeatureCommands;
using CarBookApp.Application.Features.Mediator.Commands.LocationCommands;
using CarBookApp.Application.Interfaces;
using CarBookApp.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApp.Application.Features.Mediator.Handlers.LocationHandlers
{
    public class RemoveTestimonialCommandHandler : IRequestHandler<RemoveLocationCommand>
    {
        private readonly IRepository<Location> _repository;

        public RemoveTestimonialCommandHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveLocationCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}