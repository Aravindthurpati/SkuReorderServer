using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Expiryreason
{
    public int Reasonid { get; set; }

    public string Reasontype { get; set; } = null!;
}
