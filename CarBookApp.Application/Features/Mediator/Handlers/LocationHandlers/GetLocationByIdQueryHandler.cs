
using CarBookApp.Application.Interfaces;
using CarBookApp.Domain.Entities;
using MediatR;

using CarBookApp.Application.Features.Mediator.Queries.LocationQueries;
using CarBookApp.Application.Features.Mediator.Results.LocationResults;

namespace CarBookApp.Application.Locations.Mediator.Handlers.LocationHandlers
{
    public class GetTestimonialByIdQueryHandler : IRequestHandler<GetLocationByIdQuery, GetLocationByIdQueryResult>
    {
        private readonly IRepository<Location> _repository;

        public GetTestimonialByIdQueryHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<GetLocationByIdQueryResult> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetLocationByIdQueryResult
            {
                LocationID = values.LocationID,
                Name = values.Name,
            };
        }
    }
}
