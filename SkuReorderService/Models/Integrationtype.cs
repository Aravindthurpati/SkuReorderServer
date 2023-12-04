using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Integrationtype
{
    public int Uniqueid { get; set; }

    public string Integrationname { get; set; } = null!;

    public bool? Isactive { get; set; }

    public DateTime Entrydate { get; set; }

    public string? Type { get; set; }

    public virtual ICollection<Carrier> Carriers { get; set; } = new List<Carrier>();

    public virtual ICollection<Integrationcarriermapping> Integrationcarriermappings { get; set; } = new List<Integrationcarriermapping>();

    public virtual ICollection<Integrationchannel> Integrationchannels { get; set; } = new List<Integrationchannel>();

    public virtual ICollection<Integrationproperty> Integrationproperties { get; set; } = new List<Integrationproperty>();

    public virtual ICollection<Ordererrorlog> Ordererrorlogs { get; set; } = new List<Ordererrorlog>();

    public virtual ICollection<Property> Properties { get; set; } = new List<Property>();
}
