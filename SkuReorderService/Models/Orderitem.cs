﻿using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Orderitem
{
    public int Skuid { get; set; }

    public int Orderqty { get; set; }

    public int Bkoqty { get; set; }

    public int Shipqty { get; set; }

    public int Cancelqty { get; set; }

    public decimal Itemcost { get; set; }

    public decimal Extitemcost { get; set; }

    public int? Manifestid { get; set; }

    public int Orderid { get; set; }

    public int Uniqueid { get; set; }

    public int? Locationid { get; set; }

    public int? Returnqty { get; set; }

    public string? Apprefid { get; set; }

    public string? Skulineno { get; set; }

    public string[]? Kitid { get; set; }

    public string[]? Kitqty { get; set; }

    public string? Uom { get; set; }

    public string? Variencerefid { get; set; }

    public string? Buyerspartnum { get; set; }

    public string? Upc { get; set; }

    public virtual Whlocation? Location { get; set; }

    public virtual Manifest? Manifest { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual ICollection<Orderitemshistory> Orderitemshistories { get; set; } = new List<Orderitemshistory>();

    public virtual Sku Sku { get; set; } = null!;
}
