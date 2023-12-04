using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Whmodule
{
    public string Modulename { get; set; } = null!;

    public bool? Isactive { get; set; }

    public DateOnly Createddate { get; set; }

    public int Uniqueid { get; set; }

    public int? Parentid { get; set; }

    public virtual ICollection<Whmodule> InverseParent { get; set; } = new List<Whmodule>();

    public virtual Whmodule? Parent { get; set; }

    public virtual ICollection<Whusermodule> Whusermodules { get; set; } = new List<Whusermodule>();
}
