using CarBookApp.Application.Features.CQRS.Queries.BrandQueries;
using CarBookApp.Application.Features.CQRS.Results.BrandResults;
using CarBookApp.Application.Interfaces;
using CarBookApp.Domain.Entities;

namespace CarBookApp.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler
    {
        private readonly IRepository<Brand> _repository;

        public GetBrandByIdQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }
        public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetBrandByIdQueryResult
            {
               BrandID = values.BrandID,
               Name = values.Name,
            };
        }
    }
}
