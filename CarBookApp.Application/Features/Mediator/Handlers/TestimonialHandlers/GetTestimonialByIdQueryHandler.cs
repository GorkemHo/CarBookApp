
using CarBookApp.Application.Interfaces;
using CarBookApp.Domain.Entities;
using MediatR;

using CarBookApp.Application.Features.Mediator.Queries.TestimonialQueries;
using CarBookApp.Application.Features.Mediator.Results.TestimonialResults;

namespace CarBookApp.Application.Testimonials.Mediator.Handlers.TestimonialHandlers
{
    public class GetTestimonialByIdQueryHandler : IRequestHandler<GetTestimonialByIdQuery, GetTestimonialByIdQueryResult>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialByIdQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetTestimonialByIdQueryResult
            {
                TestimonialID = values.TestimonialID,
                Name = values.Name,
                Comment = values.Comment,
                Title = values.Title,
                ImageUrl = values.ImageUrl,
            };
        }
    }
}
