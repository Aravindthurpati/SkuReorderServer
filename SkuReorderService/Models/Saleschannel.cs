using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Saleschannel
{
    public int Saleschannelid { get; set; }

    public string Saleschannel1 { get; set; } = null!;

    public bool? Isactive { get; set; }

    public DateTime Entrydate { get; set; }

    public int? Entryuserid { get; set; }

    public int? Saleschannelcode { get; set; }

    public virtual ICollection<Saleschannelmapping> Saleschannelmappings { get; set; } = new List<Saleschannelmapping>();

    public virtual ICollection<Skuautofill> Skuautofills { get; set; } = new List<Skuautofill>();
}
