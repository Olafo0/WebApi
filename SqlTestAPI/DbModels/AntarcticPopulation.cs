using System;
using System.Collections.Generic;

namespace SqlTestAPI.DbModels;

public partial class AntarcticPopulation
{
    public int SpeciesId { get; set; }

    public string Locality { get; set; } = null!;

    public int? PopulationCount { get; set; }

    public DateTime DateOfCount { get; set; }

    public virtual AntarcticSpecy Species { get; set; } = null!;
}
