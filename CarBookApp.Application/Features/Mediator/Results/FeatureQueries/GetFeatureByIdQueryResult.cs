﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApp.Application.Features.Mediator.Results.FeatureQueries
{
    public class GetFeatureByIdQueryResult
    {
        public int FeatureID { get; set; }
        public string Name { get; set; }
    }
}
