using System;
using System.Collections.Generic;

namespace SqlTestAPI.DbModels;

public partial class CaliforniaSighting
{
    public int SightingId { get; set; }

    public string? CommonName { get; set; }

    public string? ScientificName { get; set; }

    public string? LocationOfSighting { get; set; }

    public DateTime? SightingDate { get; set; }
}
