using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Property
{
    public int Integrationpropertyid { get; set; }

    public int Integrationtypeid { get; set; }

    public string Propertyname { get; set; } = null!;

    public int? Propertyid { get; set; }

    public virtual Integrationtype Integrationtype { get; set; } = null!;
}
