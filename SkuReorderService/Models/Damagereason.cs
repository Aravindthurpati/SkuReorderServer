using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Damagereason
{
    public string? Damagecode { get; set; }

    public string? Description { get; set; }

    public int Damageid { get; set; }
}
