﻿using MediatR;

using Rems.Domain.Entities;
using Rems.Application.Common;

using System.Data;
using System.Collections.Generic;

namespace Rems.Application.CQRS.Experiments.Queries.Experiments
{
    public class MeanTreatmentDataByTraitQuery : IRequest<SeriesData>
    {
        public int TreatmentId { get; set; }

        public string TraitName { get; set; }
    }
}
