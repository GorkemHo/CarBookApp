using CarBookApp.Application.Features.CQRS.Queries.CategoryQueries;
using CarBookApp.Application.Features.CQRS.Queries.ContactQueries;
using CarBookApp.Application.Features.CQRS.Results.CategoryResults;
using CarBookApp.Application.Features.CQRS.Results.ContactResults;
using CarBookApp.Application.Interfaces;
using CarBookApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApp.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class GetContactByIdQueryHandler
    {
        private readonly IRepository<Contact> _repository;

        public GetContactByIdQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetContactByIdQueryResult
            {
                ContactID = values.ContactID,
                Name = values.Name,
                Subject = values.Subject,
                SendDate = values.SendDate,
                Message = values.Message,
                Email = values.Email
            };
        }
    }
}
