﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using MediatR;
using Rems.Application.Common.Extensions;
using Rems.Application.Common.Interfaces;
using Rems.Domain.Entities;

using Unit = MediatR.Unit;

namespace Rems.Application.CQRS
{
    /// <summary>
    /// Inserts the measured traits of soil layers into the database
    /// </summary>
    public class InsertSoilLayerTraitsCommand : IRequest
    {
        /// <summary>
        /// The source data
        /// </summary>
        public DataTable Table { get; set; }

        public Type Type { get; set; }

        public Type Dependency { get; set; }

        public Action IncrementProgress { get; set; }
    }

    public class InsertSoilLayerTraitsCommandHandler : IRequestHandler<InsertSoilLayerTraitsCommand>
    {
        private readonly IRemsDbContext _context;

        public InsertSoilLayerTraitsCommandHandler(IRemsDbContext context)
        {
            _context = context;
        }

        public Task<Unit> Handle(InsertSoilLayerTraitsCommand request, CancellationToken cancellationToken)
            => Task.Run(() => Handler(request));

        private Unit Handler(InsertSoilLayerTraitsCommand request)
        {
            // Assume the first 3 columns in the table are not trait columns, so we 'skip' them
            int skip = 3;
            var traits = _context.GetTraitsFromColumns(request.Table, skip, "SoilLayer");
            var entities = new List<SoilLayerTrait>();

            foreach (DataRow row in request.Table.Rows)
            {
                // Assume the first column contains soil type data
                var soil = _context.Soils.FirstOrDefault(s => s.SoilType == row[0].ToString());
                
                // Assume the second column contains 'from depth' data
                int from = Convert.ToInt32(row[1]);

                // Assume the third column contains 'to depth' data
                int to = Convert.ToInt32(row[2]);

                // Look for a match in the database
                var match = _context.SoilLayers.SingleOrDefault(s => s.Soil == soil && s.FromDepth == from && s.ToDepth == to);

                // If no match was found, create a new layer
                var layer = match ?? new SoilLayer { Soil = soil, FromDepth = from, ToDepth = to };
                _context.Attach(layer);

                traits.ForEach(trait => 
                {
                    // Do not store empty values
                    var value = row[trait.Name];
                    if (value is DBNull) return;

                    // Look for an existing soil layer trait
                    var existing = _context.SoilLayerTraits.SingleOrDefault(s => s.Trait == trait && s.SoilLayer == layer);

                    // If none exist, create a new soil layer trait
                    var slt = existing ?? new SoilLayerTrait{ Trait = trait, SoilLayer = layer };

                    // Update the value
                    slt.Value = Convert.ToDouble(value);
                    entities.Add(slt);
                });                

                request.IncrementProgress();
            }
            _context.SaveChanges();

            // Add the traits once the soil layers have been saved
            _context.AttachRange(entities.ToArray());
            _context.SaveChanges();

            return Unit.Value;
        }
    }
}
