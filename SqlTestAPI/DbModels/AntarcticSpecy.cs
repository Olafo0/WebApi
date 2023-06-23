using System;
using System.Collections.Generic;

namespace SqlTestAPI.DbModels;

public partial class AntarcticSpecy
{
    public int SpeciesId { get; set; }

    public string? ScientificName { get; set; }

    public string? CommonName { get; set; }

    public virtual ICollection<AntarcticPopulation> AntarcticPopulations { get; set; } = new List<AntarcticPopulation>();
}
