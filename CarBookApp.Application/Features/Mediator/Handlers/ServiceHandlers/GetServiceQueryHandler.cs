
using CarBookApp.Application.Interfaces;
using CarBookApp.Domain.Entities;
using MediatR;

using CarBookApp.Application.Features.Mediator.Results.ServiceResults;
using CarBookApp.Application.Features.Mediator.Queries.GetServiceQueries;

namespace CarBookApp.Application.Services.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceQueryHandler : IRequestHandler<GetServiceQuery, List<GetServiceQueryResult>>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetServiceQueryResult>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetServiceQueryResult
            {
                ServiceID = x.ServiceID,
                IconUrl = x.IconUrl,
                Title = x.Title,
                Description = x.Description,
            }).ToList();
        }
    }
}
