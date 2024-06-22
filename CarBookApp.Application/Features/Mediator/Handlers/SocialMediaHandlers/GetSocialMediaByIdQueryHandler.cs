
using CarBookApp.Application.Interfaces;
using CarBookApp.Domain.Entities;
using MediatR;
using CarBookApp.Application.Features.Mediator.Results.SocialMediaResults;
using CarBookApp.Application.Features.Mediator.Queries.SocialMediaQueries;

namespace CarBookApp.Application.SocialMedias.Mediator.Handlers.SocialMediaHandlers
{
    public class GetSocialMediaByIdQueryHandler : IRequestHandler<GetSocialMediaByIdQuery, GetSocialMediaByIdQueryResult>
    {
        private readonly IRepository<SocialMedia> _repository;

        public GetSocialMediaByIdQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<GetSocialMediaByIdQueryResult> Handle(GetSocialMediaByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetSocialMediaByIdQueryResult
            {
                SocialMediaID = values.SocialMediaID,
                Name = values.Name,
                Url = values.Url,
                Icon = values.Icon
            };
        }
    }
}
