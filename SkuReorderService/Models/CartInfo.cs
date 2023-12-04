using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class CartInfo
{
    public int Uniqueid { get; set; }

    public int Cartsize { get; set; }

    public string Cartname { get; set; } = null!;

    public int Start { get; set; }

    public int End { get; set; }

    public bool? Isactive { get; set; }

    public int? Entryuserid { get; set; }

    public DateTime? Entrydate { get; set; }

    public int? Modifieduserid { get; set; }

    public DateTime? Modifieddate { get; set; }

    public virtual ICollection<Carttote> Carttotes { get; set; } = new List<Carttote>();

    public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();

    public virtual ICollection<Ordersjobitem> Ordersjobitems { get; set; } = new List<Ordersjobitem>();
}
