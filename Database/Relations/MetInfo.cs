﻿using System;
using System.Collections.Generic;

namespace Database
{
    [Relation("MetInfo")]
    public class MetInfo
    {
        public int MetInfoId { get; set; }
        public int? MetStationId { get; set; }
        public string Variable { get; set; }
        public string Value { get; set; }

        public virtual MetStations MetStation { get; set; }
    }
}