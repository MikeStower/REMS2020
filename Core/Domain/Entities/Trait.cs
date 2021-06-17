﻿using Rems.Domain.Attributes;
using System.Collections.Generic;

namespace Rems.Domain.Entities
{
    [ExcelSource(RemsSource.Information, "Traits")]
    public class Trait : IEntity
    {
        public Trait()
        {
            MetData = new HashSet<MetData>();
            PlotData = new HashSet<PlotData>();
            SoilData = new HashSet<SoilData>();
            SoilLayerData = new HashSet<SoilLayerData>();
            SoilLayerTraits = new HashSet<SoilLayerTrait>();
            SoilTraits = new HashSet<SoilTrait>();
            Stats = new HashSet<Stat>();
        }

        public int TraitId { get; set; }

        public int? UnitId { get; set; }

        [Expected("Trait", "TraitName", "Name")]
        public string Name { get; set; }

        [Expected("Type", "TraitType")]
        public string Type { get; set; }

        [Expected("Description")]
        public string Description { get; set; }

        [Expected("Notes")]
        public string Notes { get; set; }

        [Expected("Unit", "Units", "DefaultUnits")]
        public virtual Unit Unit { get; set; }
        
        public virtual ICollection<MetData> MetData { get; set; }
        public virtual ICollection<PlotData> PlotData { get; set; }
        public virtual ICollection<SoilData> SoilData { get; set; }
        public virtual ICollection<SoilLayerData> SoilLayerData { get; set; }
        public virtual ICollection<SoilLayerTrait> SoilLayerTraits { get; set; }
        public virtual ICollection<SoilTrait> SoilTraits { get; set; }
        public virtual ICollection<Stat> Stats { get; set; }
    }
}
