﻿using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Holidaylist
{
    public int Uniqueid { get; set; }

    public string? Holidayname { get; set; }

    public DateTime? Holidaydate { get; set; }
}
