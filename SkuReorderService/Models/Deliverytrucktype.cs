﻿using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Deliverytrucktype
{
    public int Uniqueid { get; set; }

    public string Deliverytrucktype1 { get; set; } = null!;

    public bool? Isactive { get; set; }
}
