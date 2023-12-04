using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Saleschannelmapping
{
    public int Uniqueid { get; set; }

    public int Saleschannelid { get; set; }

    public int Clientid { get; set; }

    public string? Saleschannelcode { get; set; }

    public string? Docurl { get; set; }

    public bool? Isactive { get; set; }

    public int Entryuserid { get; set; }

    public DateTime Entrydate { get; set; }

    public bool Shippingauto { get; set; }

    public string? _3rdpartyaccno { get; set; }

    public int? Modifieduserid { get; set; }

    public DateTime? Modifieddate { get; set; }

    public virtual Whclient Client { get; set; } = null!;

    public virtual Whuser Entryuser { get; set; } = null!;

    public virtual Saleschannel Saleschannel { get; set; } = null!;
}
