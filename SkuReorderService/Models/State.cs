using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class State
{
    public int Id { get; set; }

    public string State1 { get; set; } = null!;

    public string? Statename { get; set; }

    public string? Country { get; set; }
}
