﻿using System;
using System.Threading.Tasks;
using System.Threading;

using MediatR;
using Models.Core;
using Rems.Application.Common.Interfaces;

namespace Rems.Application.CQRS
{
    /// <summary>
    /// Generates an APSIM Zone model for an experiment
    /// </summary>
    public class ZoneQuery : IRequest<Zone>
    {   
        /// <summary>
        /// The source experiment
        /// </summary>
        public int ExperimentId { get; set; }
    }

    public class ZoneQueryHandler : IRequestHandler<ZoneQuery, Zone>
    {
        private readonly IRemsDbContext _context;

        public ZoneQueryHandler(IRemsDbContext context)
        {
            _context = context;
        }

        public Task<Zone> Handle(ZoneQuery request, CancellationToken token) => Task.Run(() => Handler(request));

        private Zone Handler(ZoneQuery request)
        {
            var field = _context.Experiments.Find(request.ExperimentId).Field;

            var zone = new Zone()
            {
                Name = "Field",
                Slope = field.Slope.GetValueOrDefault(),
                Area = 1
            };

            return zone;
        }
    }
}
