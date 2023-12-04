using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Carrier
{
    public int Carrierid { get; set; }

    public string Carriername { get; set; } = null!;

    public bool? Isactive { get; set; }

    public string? Urltrackprefix { get; set; }

    public string? Urltrackpostfix { get; set; }

    public int? Intgrationtypeid { get; set; }

    public virtual ICollection<Carrierservice> Carrierservices { get; set; } = new List<Carrierservice>();

    public virtual ICollection<Carriertype> Carriertypes { get; set; } = new List<Carriertype>();

    public virtual ICollection<Clientshipmethod> Clientshipmethods { get; set; } = new List<Clientshipmethod>();

    public virtual Integrationtype? Intgrationtype { get; set; }

    public virtual ICollection<Manifest> Manifests { get; set; } = new List<Manifest>();
}
