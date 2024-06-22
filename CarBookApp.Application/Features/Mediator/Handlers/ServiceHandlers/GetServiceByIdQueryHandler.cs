
using CarBookApp.Application.Interfaces;
using CarBookApp.Domain.Entities;
using MediatR;
using CarBookApp.Application.Features.Mediator.Results.ServiceResults;
using CarBookApp.Application.Features.Mediator.Queries.GetServiceQueries;

namespace CarBookApp.Application.Services.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceByIdQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetServiceByIdQueryResult
            {
                ServiceID = values.ServiceID,
                Description = values.Description,
                Title = values.Title,
                IconUrl = values.IconUrl,
            };
        }
    }
}
