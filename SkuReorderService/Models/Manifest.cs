using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Manifest
{
    public int Manifestid { get; set; }

    public string Manifeststatus { get; set; } = null!;

    public string? Comments { get; set; }

    public int? Postuserid { get; set; }

    public DateTime? Postdate { get; set; }

    public DateTime Createdate { get; set; }

    public int Createuserid { get; set; }

    public DateTime? Canceldate { get; set; }

    public int? Canceluserid { get; set; }

    public int? Manifestsequence { get; set; }

    public int Orderid { get; set; }

    public DateTime? Shipdate { get; set; }

    public int? Carrierid { get; set; }

    public int? Carrierserviceid { get; set; }

    public string? Carrieracct { get; set; }

    public string? Otherfreight { get; set; }

    public string? Servicelevel { get; set; }

    public int? Unitssent { get; set; }

    public int? Packagessent { get; set; }

    public int? Palletssent { get; set; }

    public int? Cartonssent { get; set; }

    public string? Batchjobid { get; set; }

    public DateTime? Batchjobdate { get; set; }

    public bool Ismailsent { get; set; }

    public virtual Carrier? Carrier { get; set; }

    public virtual Carrierservice? Carrierservice { get; set; }

    public virtual ICollection<Manifestcomment> Manifestcomments { get; set; } = new List<Manifestcomment>();

    public virtual ICollection<Manifestpackage> Manifestpackages { get; set; } = new List<Manifestpackage>();

    public virtual Order Order { get; set; } = null!;

    public virtual ICollection<Orderitem> Orderitems { get; set; } = new List<Orderitem>();

    public virtual ICollection<Orderitemshistory> Orderitemshistories { get; set; } = new List<Orderitemshistory>();

    public virtual ICollection<Ordershipaddresslog> Ordershipaddresslogs { get; set; } = new List<Ordershipaddresslog>();

    public virtual ICollection<Ordersjobitem> Ordersjobitems { get; set; } = new List<Ordersjobitem>();
}
