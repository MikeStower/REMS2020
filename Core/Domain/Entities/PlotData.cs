﻿using Rems.Domain.Interfaces;
using System;

namespace Rems.Domain.Entities
{
    public class PlotData : IEntity, IValue
    {
        public int PlotDataId { get; set; }

        public int PlotId { get; set; }

        public int TraitId { get; set; }

        public DateTime Date { get; set; }

        public string Sample { get; set; }

        public double Value { get; set; }

        public int? UnitId { get; set; }


        public virtual Plot Plot { get; set; }
        public virtual Trait Trait { get; set; }
        public virtual Unit Unit { get; set; }
        
    }
}
