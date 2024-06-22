
using CarBookApp.Application.Interfaces;
using CarBookApp.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBookApp.Application.Features.Mediator.Queries.LocationQueries;
using CarBookApp.Application.Features.Mediator.Results.LocationResults;

namespace CarBookApp.Application.Locations.Mediator.Handlers.LocationHandlers
{
    public class GetTestimonialQueryHandler : IRequestHandler<GetLocationQuery, List<GetLocationQueryResult>>
    {
        private readonly IRepository<Location> _repository;

        public GetTestimonialQueryHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLocationQueryResult>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetLocationQueryResult
            {
                LocationID = x.LocationID,
                Name = x.Name,
            }).ToList();
        }
    }
}
