using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Localization
{
    public int Uniqueid { get; set; }

    public string English { get; set; } = null!;

    public string? Spanish { get; set; }
}
