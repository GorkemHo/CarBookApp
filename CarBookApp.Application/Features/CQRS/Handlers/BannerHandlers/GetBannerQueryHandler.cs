using CarBookApp.Application.Features.CQRS.Results.BannerResults;
using CarBookApp.Application.Interfaces;
using CarBookApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApp.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerQueryHandler
    {
        private readonly IRepository<Banner> _respository;

        public GetBannerQueryHandler(IRepository<Banner> respository)
        {
            _respository = respository;
        }
        public async Task<List<GetBannerQueryResult>> Handle()
        {
            var values = await _respository.GetAllAsync();
            return values.Select(x => new GetBannerQueryResult
            {
                BannerID = x.BannerID,
                Description = x.Description,
                Title = x.Title,
                VideoDescription = x.VideoDescription,
                VideoUrl = x.VideoUrl,
            }).ToList();
        }
    }
}
