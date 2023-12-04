using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Skushippingbox
{
    public int Uniqueid { get; set; }

    public string Shippingbox { get; set; } = null!;

    public bool? Isactive { get; set; }

    public DateTime Entrydate { get; set; }

    public virtual ICollection<Skupackage> Skupackages { get; set; } = new List<Skupackage>();
}
