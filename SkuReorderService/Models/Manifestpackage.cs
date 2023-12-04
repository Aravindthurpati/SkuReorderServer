﻿using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Manifestpackage
{
    public int Packageid { get; set; }

    public int Manifestid { get; set; }

    public int Shipviaid { get; set; }

    public double Weight { get; set; }

    public decimal Cost { get; set; }

    public string? Trackingnumber { get; set; }

    public int Shipuserid { get; set; }

    public DateTime Shipdate { get; set; }

    public int Width { get; set; }

    public int Height { get; set; }

    public int Length { get; set; }

    public int? Packagenumber { get; set; }

    public bool? Isfulfilled { get; set; }

    public string? Servicelevel { get; set; }

    public int? Unitssent { get; set; }

    public int? Packagessent { get; set; }

    public int? Palletssent { get; set; }

    public int? Cartonssent { get; set; }

    public decimal? Negotiatecost { get; set; }

    public string? Ssccnum { get; set; }

    public decimal? Insuredvalue { get; set; }

    public virtual Manifest Manifest { get; set; } = null!;

    public virtual ICollection<Manifestskupackagedetail> Manifestskupackagedetails { get; set; } = new List<Manifestskupackagedetail>();

    public virtual ICollection<Orderitemshistory> Orderitemshistories { get; set; } = new List<Orderitemshistory>();

    public virtual Carrierservice Shipvia { get; set; } = null!;
}