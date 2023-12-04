using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Manifestcomment
{
    public int Uniqueid { get; set; }

    public int Createduserid { get; set; }

    public DateTime Createddate { get; set; }

    public string Comments { get; set; } = null!;

    public int Manifestid { get; set; }

    public virtual Whuser Createduser { get; set; } = null!;

    public virtual Manifest Manifest { get; set; } = null!;
}
