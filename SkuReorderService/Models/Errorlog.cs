using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Errorlog
{
    public int Uniqueid { get; set; }

    public string Errormsg { get; set; } = null!;

    public DateTime Entrydate { get; set; }
}
