﻿using Models;
using Models.Factorial;
using Rems.Application.Common;
using Rems.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rems.Application.CQRS
{
    /// <summary>
    /// Generates an APSIM Permutation model for an experiment
    /// </summary>
    public class FactorsQuery : ContextQuery<Factors>
    { 
        /// <summary>
        /// The experiment to model
        /// </summary>
        public int ExperimentId { get; set; }

        public Markdown Report { get; set; }

        /// <inheritdoc/>
        public class Handler : BaseHandler<FactorsQuery>
        {
            public Handler(IRemsDbContextFactory factory) : base(factory) { }
        }

        /// <inheritdoc/>
        protected override Factors Run()
        {
            var experiment = _context.Experiments.Find(ExperimentId);

            var treatments = new Factor { Name = "Treatment" };

            foreach (var treatment in experiment.Treatments)
            {
                var factor = new CompositeFactor { Name = treatment.Name};
                
                factor.Specifications = treatment.Designs.Select(d => d.Level)
                    .SelectMany(l => GetSpecification(l))
                    .ToList();

                Func<Domain.Entities.Irrigation, Operation> f1 = i 
                    => new Operation { Date = i.Date.ToString(), Action = $"[Irrigation].Apply({i.Amount})" };
                AddOperations(factor, "Irrigations", treatment.Irrigations, f1);

                Func<Domain.Entities.Fertilization, Operation> f2 = f 
                    => new Operation { Date = f.Date.ToString(), Action = FertAction(f) };
                AddOperations(factor, "Fertilisations", treatment.Fertilizations, f2);

                treatments.Children.Add(factor);
            }
            
            var model = new Factors { Name = "Factors" };
            model.Children.Add(treatments);

            return model;
        }

        private string[] GetSpecification(Domain.Entities.Level level)
        {
            if (level.Specification != null)
                return level.Specification.Split(';').Where(s => s != "").ToArray();

            switch (level.Factor.Name)
            {
                case "Cultivar":
                    return new[] { "[Sowing].Script.Cultivar = " + level.Name };

                case "Sow Date":
                case "Planting Date":
                    return new[] { "[Sowing].Script.SowDate = " + level.Name };

                case "Row spacing":
                    return new[] { "[Sowing].Script.RowSpacing = " + level.Name };

                case "Nitrogen":
                case "N Rates":
                case "NRates":
                    return new[] { "[Fertilisation].Script.Amount = " + level.Name};

                case "Population":
                case "Treatment":
                case "Density":
                case "DayLength":
                case "Irrigation":
                default:
                    Report.AddLine("* No specification found for factor " + level.Factor.Name);
                    return new[] { "" };
            }
        }

        private Operations AddOperations<T>(CompositeFactor factor, string name, IEnumerable<T> items, Func<T, Operation> func)
        {
            factor.Specifications.Add($"[{name}]");
            var ops = new Operations{ Name = name };
            ops.Operation = items.Select(func).ToList();
            factor.Children.Add(ops);
            return ops;
        }

        private string FertAction(Domain.Entities.Fertilization f)
        {
            var type = f.Fertilizer.Name;

            if (!Enum.IsDefined(typeof(Fertiliser.Types), type))
                switch (type)
                {
                    case "Aqua ammonia":
                        type = Fertiliser.Types.NH4N.ToString();
                        break;

                    default:
                        type = Fertiliser.Types.NO3N.ToString();
                        Report.AddLine($"Matching APSIM fertiliser type for {type} not found in treatment {f.Treatment.Name}. Using default type instead (NO3N)");
                        break;
                }

            return $"[Fertiliser].Apply({f.Depth}, Fertiliser.Types.{type}, {f.Amount})";
        }
    }
}