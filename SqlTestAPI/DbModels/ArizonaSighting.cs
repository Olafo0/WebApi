using System;
using System.Collections.Generic;

namespace SqlTestAPI.DbModels;

public partial class ArizonaSighting
{
    public int SightingId { get; set; }

    public string? CommonName { get; set; }

    public string? ScientificName { get; set; }

    public string? SightingLocation { get; set; }

    public DateTime? SightingDate { get; set; }
}
