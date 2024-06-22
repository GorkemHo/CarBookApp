
using CarBookApp.Application.Interfaces;
using CarBookApp.Domain.Entities;
using MediatR;

using CarBookApp.Application.Features.Mediator.Results.SocialMediaResults;
using CarBookApp.Application.Features.Mediator.Queries.SocialMediaQueries;

namespace CarBookApp.Application.SocialMedias.Mediator.Handlers.SocialMediaHandlers
{
    public class GetSocialMediaQueryHandler : IRequestHandler<GetSocialMediaQuery   , List<GetSocialMediaQueryResult>>
    {
        private readonly IRepository<SocialMedia> _repository;

        public GetSocialMediaQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetSocialMediaQueryResult>> Handle(GetSocialMediaQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetSocialMediaQueryResult
            {
                SocialMediaID = x.SocialMediaID,
                Icon = x.Icon,
                Url = x.Url,
                Name = x.Name
            }).ToList();
        }
    }
}
