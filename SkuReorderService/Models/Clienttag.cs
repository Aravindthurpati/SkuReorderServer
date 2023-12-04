using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Clienttag
{
    public int Uniqueid { get; set; }

    public int Clientid { get; set; }

    public string Tagtype { get; set; } = null!;

    public string Tagname { get; set; } = null!;

    public bool Status { get; set; }

    public virtual Whclient Client { get; set; } = null!;
}
