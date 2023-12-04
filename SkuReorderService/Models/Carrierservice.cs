using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Carrierservice
{
    public int Shipviaid { get; set; }

    public string Shipvianame { get; set; } = null!;

    public bool? Isactive { get; set; }

    public short? Shippriority { get; set; }

    public int Clientid { get; set; }

    public string? Accountno { get; set; }

    public bool Isthirdparty { get; set; }

    public int Carrierid { get; set; }

    public virtual ICollection<Batching> Batchings { get; set; } = new List<Batching>();

    public virtual Carrier Carrier { get; set; } = null!;

    public virtual Whclient Client { get; set; } = null!;

    public virtual ICollection<Integrationcarriermapping> Integrationcarriermappings { get; set; } = new List<Integrationcarriermapping>();

    public virtual ICollection<Manifestpackage> Manifestpackages { get; set; } = new List<Manifestpackage>();

    public virtual ICollection<Manifest> Manifests { get; set; } = new List<Manifest>();

    public virtual ICollection<Ordersshipment> Ordersshipments { get; set; } = new List<Ordersshipment>();
}
