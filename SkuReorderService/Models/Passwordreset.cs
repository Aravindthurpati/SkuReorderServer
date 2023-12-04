using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Passwordreset
{
    public int Id { get; set; }

    public int FkWhuser { get; set; }

    public bool Isreset { get; set; }

    public Guid Resetlink { get; set; }

    public DateTime Createdate { get; set; }

    public DateTime Expirationdate { get; set; }

    public DateTime? Resetdate { get; set; }

    public virtual Whuser FkWhuserNavigation { get; set; } = null!;
}
