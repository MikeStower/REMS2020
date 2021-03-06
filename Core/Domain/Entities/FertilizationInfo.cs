﻿namespace Rems.Domain.Entities
{
    public class FertilizationInfo : IEntity
    {
        public int FertilizationInfoId { get; set; }

        public int? FertilizationId { get; set; }

        public string Variable { get; set; }

        public string Value { get; set; }


        public virtual Fertilization Fertilization { get; set; }

    }
}
