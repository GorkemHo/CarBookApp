using CarBookApp.Application.Features.Mediator.Queries.FooterAddressQueries;
using CarBookApp.Application.Features.Mediator.Results.FeatureQueries;
using CarBookApp.Application.Features.Mediator.Results.FooterAddressResults;
using CarBookApp.Application.Interfaces;
using CarBookApp.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApp.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class GetFooterAddressByIdQueryHandler : IRequestHandler<GetFooterAddressByIdQuery, GetFooterAddressByIdQueryResult>
    {
        private readonly IRepository<FooterAddress> _repository;

        public GetFooterAddressByIdQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }
        public async Task<GetFooterAddressByIdQueryResult> Handle(GetFooterAddressByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetFooterAddressByIdQueryResult
            {
                Address = values.Address,
                Phone = values.Phone,
                Email = values.Email,
                Description = values.Description,
                FooterAddressID = values.FooterAddressID
            };
        }
    }
}
