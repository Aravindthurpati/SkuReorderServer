using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Country
{
    public string? Country1 { get; set; }

    public int Id { get; set; }

    public virtual ICollection<Sku> Skus { get; set; } = new List<Sku>();
}
