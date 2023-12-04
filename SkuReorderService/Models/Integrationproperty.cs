using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Integrationproperty
{
    public int Uniqueid { get; set; }

    public string Integrationpropertyname { get; set; } = null!;

    public int Integrationtypeid { get; set; }

    public string Integrationdatatype { get; set; } = null!;

    public string Integrationdisplaytext { get; set; } = null!;

    public bool? Status { get; set; }

    public DateTime Entrydate { get; set; }

    public virtual ICollection<Integrationdetail> Integrationdetails { get; set; } = new List<Integrationdetail>();

    public virtual Integrationtype Integrationtype { get; set; } = null!;
}
