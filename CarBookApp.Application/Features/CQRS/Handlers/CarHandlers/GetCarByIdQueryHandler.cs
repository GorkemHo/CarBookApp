using CarBookApp.Application.Features.CQRS.Queries.BrandQueries;
using CarBookApp.Application.Features.CQRS.Queries.CarQueries;
using CarBookApp.Application.Features.CQRS.Results.BrandResults;
using CarBookApp.Application.Features.CQRS.Results.CarResults;
using CarBookApp.Application.Interfaces;
using CarBookApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApp.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCarByIdQueryResult
            {
               BigImageUrl = values.BigImageUrl,
               BrandID = values.BrandID,
               CarID = values.CarID,
               CoverImageUrl = values.CoverImageUrl,
               Fuel = values.Fuel,
               Km = values.Km,
               Luggage = values.Luggage,
               Model = values.Model,
               Seat = values.Seat,
               Transmission = values.Transmission
            };
        }
    }
}
