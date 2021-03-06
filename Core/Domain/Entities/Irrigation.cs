﻿using Rems.Domain.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rems.Domain.Entities
{
    [ExcelFormat("Experiments", 1, false, "Irrigation")]
    public class Irrigation : ITreatment
    {
        public Irrigation()
        {
            IrrigationInfo = new HashSet<IrrigationInfo>();
        }

        public int IrrigationId { get; set; }

        public int? MethodId { get; set; }

        public int TreatmentId { get; set; }

        [Expected("Date")]
        public DateTime Date { get; set; }

        [Expected("Amount")]
        public double Amount { get; set; }

        [Expected("Notes")]
        public string Notes { get; set; }

        [NotMapped]
        [Expected("Experiment", "ExpID")]
        public Experiment Experiment { get; set; }

        [Expected("Method", "Irrigation Method")]
        public virtual Method Method { get; set; }
        
        [Expected("Treatment", "TreatmentName", "Treatment Name")]
        public virtual Treatment Treatment { get; set; }

        public virtual ICollection<IrrigationInfo> IrrigationInfo { get; set; }
    }
}
