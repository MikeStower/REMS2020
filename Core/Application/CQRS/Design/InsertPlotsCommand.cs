﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using MediatR;
using Rems.Application.Common;
using Rems.Application.Common.Extensions;
using Rems.Application.Common.Interfaces;
using Rems.Domain.Entities;

using Unit = MediatR.Unit;

namespace Rems.Application.CQRS
{
    public class InsertPlotsCommand : IRequest
    {
        public DataTable Table { get; set; }

        public Action IncrementProgress { get; set; }
    }

    public class InsertPlotsCommandHandler : IRequestHandler<InsertPlotsCommand>
    {
        private readonly IRemsDbContext _context;

        public InsertPlotsCommandHandler(IRemsDbContext context)
        {
            _context = context;
        }

        public Task<Unit> Handle(InsertPlotsCommand request, CancellationToken cancellationToken) => Task.Run(() => Handler(request));

        private Unit Handler(InsertPlotsCommand request)
        {
            var rows = request.Table.Rows.Cast<DataRow>();

            // Group the experiment rows together
            var eGroup = rows.GroupBy(row => Convert.ToInt32(row[0]));

            var plots = new List<Plot>();

            foreach (var e in eGroup)
            {
                // Sub-group the experiment rows by treatment
                var tGroup = e.GroupBy(row => row[1].ToString());

                foreach (var t in tGroup)
                {
                    var levels = t.First().ItemArray.Skip(4).Select(o => o.ToString()).ToArray();
                    var treatment = CreateTreatment(e.Key, t.Key, levels);

                    foreach (var row in t)
                    {
                        var plot = new Plot()
                        {
                            Treatment = treatment,
                            Repetition = Convert.ToInt32(row[2]),
                            Column = Convert.ToInt32(row[3])
                        };
                        plots.Add(plot);

                        request.IncrementProgress();
                    }
                }
            }

            _context.AttachRange(plots.ToArray());
            _context.SaveChanges();

            return Unit.Value;
        }

        private Treatment CreateTreatment(int exp, string name, string[] levels)
        {
            var treatment = new Treatment()
            {
                ExperimentId = exp,
                Name = name
            };
            _context.Add(treatment);
            _context.SaveChanges();

            foreach (var level in levels)
            {
                var entity = _context.Levels.FirstOrDefault(l => l.Name == level);

                if (entity is null) continue;

                var design = new Design()
                {
                    Level = entity,
                    TreatmentId = treatment.TreatmentId
                };
                _context.Add(design);
                _context.SaveChanges();
            }

            return treatment;
        }

    }
}
