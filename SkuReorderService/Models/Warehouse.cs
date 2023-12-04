using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Warehouse
{
    public int Uniqueid { get; set; }

    public string Whname { get; set; } = null!;

    public bool? Isactive { get; set; }

    public DateTime Entrydate { get; set; }

    public int Entryuserid { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Postalcode { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public virtual Whuser Entryuser { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Whclient> Whclients { get; set; } = new List<Whclient>();

    public virtual ICollection<Whlocation> Whlocations { get; set; } = new List<Whlocation>();

    public virtual ICollection<Whuserwarehouse> Whuserwarehouses { get; set; } = new List<Whuserwarehouse>();
}
