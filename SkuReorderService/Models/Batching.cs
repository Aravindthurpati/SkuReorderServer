﻿using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Batching
{
    public int Uniqueid { get; set; }

    public int Linecount { get; set; }

    public int Clientid { get; set; }

    public DateTime Entrydate { get; set; }

    public int? Shipviaid { get; set; }

    public virtual ICollection<Batchingitem> Batchingitems { get; set; } = new List<Batchingitem>();

    public virtual Whclient Client { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Carrierservice? Shipvia { get; set; }
}
