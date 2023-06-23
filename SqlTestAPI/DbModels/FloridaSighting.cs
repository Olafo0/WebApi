using System;
using System.Collections.Generic;

namespace SqlTestAPI.DbModels;

public partial class FloridaSighting
{
    public int ObservationId { get; set; }

    public string? ScientificName { get; set; }

    public string? Locality { get; set; }

    public DateTime? SightingDatetime { get; set; }
}
