﻿using System.Collections.Generic;

namespace Rems.Domain.Entities
{
    public class SoilLayer
    {
        public SoilLayer()
        {
            SoilLayerTraits = new HashSet<SoilLayerTrait>();
        }

        public int SoilLayerId { get; set; }

        public int SoilId { get; set; }

        public int? DepthFrom { get; set; } = null;

        public int? DepthTo { get; set; } = null;


        public virtual Soil Soil { get; set; }
        public virtual ICollection<SoilLayerTrait> SoilLayerTraits { get; set; }


    }
}