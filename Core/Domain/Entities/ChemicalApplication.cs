﻿using System;


namespace Rems.Domain.Entities
{
    public class ChemicalApplication : IEntity
    {
        public int ApplicationId { get; set; }

        public int? TreatmentId { get; set; }

        public DateTime? ApplicationDate { get; set; }

        public string Target { get; set; }

        public int? ActiveIngredient { get; set; }

        public double? Amount { get; set; }

        public int? UnitId { get; set; }

        public int? MethodId { get; set; }

        public string Notes { get; set; }

        public virtual Method ApplicationMethod { get; set; }

        public virtual Treatment Treatment { get; set; }

        public virtual Unit Unit { get; set; }
    }
}
