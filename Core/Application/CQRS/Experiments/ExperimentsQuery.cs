﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

using MediatR;
using Rems.Application.Common.Interfaces;

namespace Rems.Application.CQRS
{
    /// <summary>
    /// Return a collection of all experiments paired by ID and Name
    /// </summary>
    public class ExperimentsQuery : IRequest<KeyValuePair<int, string>[]>
    { }

    public class ExperimentsQueryHandler : IRequestHandler<ExperimentsQuery, KeyValuePair<int, string>[]>
    {
        private readonly IRemsDbContext _context;

        public ExperimentsQueryHandler(IRemsDbContext context)
        {
            _context = context;
        }

        public Task<KeyValuePair<int, string>[]> Handle(ExperimentsQuery request, CancellationToken token) => Task.Run(() => Handler(request));

        private KeyValuePair<int, string>[] Handler(ExperimentsQuery request)
        {
            return _context.Experiments
                .Select(e => new KeyValuePair<int, string>(e.ExperimentId, e.Name))
                .ToArray();
        }
    }
}
