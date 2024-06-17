using CarBookApp.Application.Features.CQRS.Results.BannerResults;
using CarBookApp.Application.Features.CQRS.Results.BrandResults;
using CarBookApp.Application.Interfaces;
using CarBookApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApp.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler
    {
        private readonly IRepository<Brand> _respository;

        public GetBrandQueryHandler(IRepository<Brand> respository)
        {
            _respository = respository;
        }
        public async Task<List<GetBrandQueryResult>> Handle()
        {
            var values = await _respository.GetAllAsync();
            return values.Select(x => new GetBrandQueryResult
            {
                BrandID = x.BrandID,
                Name = x.Name,
            }).ToList();
        }
    }
}
