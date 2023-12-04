using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Order
{
    public int Clientid { get; set; }

    public int Whid { get; set; }

    public DateTime Orderdate { get; set; }

    public DateTime Createddate { get; set; }

    public int Entryuserid { get; set; }

    public DateTime? Modifieddate { get; set; }

    public decimal Ordertotal { get; set; }

    public decimal Ordertax { get; set; }

    public decimal Orderskucost { get; set; }

    public decimal Orderdiscount { get; set; }

    public bool Ispriority { get; set; }

    public int Saleschannelid { get; set; }

    public string Custorderid { get; set; } = null!;

    public string? Vendororderid { get; set; }

    public DateTime? Expectedshipdate { get; set; }

    public bool Ishold { get; set; }

    public string Orderstatus { get; set; } = null!;

    public decimal Ordershipcost { get; set; }

    public int Orderid { get; set; }

    public string? Storeid { get; set; }

    public int? Masterskuid { get; set; }

    public int? Kitqty { get; set; }

    public int? Kitcompletedqty { get; set; }

    public DateTime? Ordercompleteddate { get; set; }

    public string? Originalorderid { get; set; }

    public string? Comments { get; set; }

    public DateTime? Preferredshipdate { get; set; }

    public int? Modifieduserid { get; set; }

    public bool Isgiftorder { get; set; }

    public bool? Completeshipment { get; set; }

    public string? Giftmessage { get; set; }

    public string? Customerpo { get; set; }

    public int? Jobid { get; set; }

    public int? Toteid { get; set; }

    public bool? Ispartialkit { get; set; }

    public int? Batchid { get; set; }

    public string Ordertype { get; set; } = null!;

    public bool Iskitorder { get; set; }

    public string? Apprefid { get; set; }

    public string? Carrierlabelref { get; set; }

    public string? Internalcomments { get; set; }

    public bool? Isorderconfirmationsent { get; set; }

    public DateTime? Cargoreadydate { get; set; }

    public DateTime? Scheduleddate { get; set; }

    public string? Loaderid { get; set; }

    public virtual Batching? Batch { get; set; }

    public virtual Whclient Client { get; set; } = null!;

    public virtual Whuser Entryuser { get; set; } = null!;

    public virtual ICollection<Manifest> Manifests { get; set; } = new List<Manifest>();

    public virtual Sku? Mastersku { get; set; }

    public virtual Whuser? Modifieduser { get; set; }

    public virtual ICollection<Orderitem> Orderitems { get; set; } = new List<Orderitem>();

    public virtual ICollection<Orderitemshistory> Orderitemshistories { get; set; } = new List<Orderitemshistory>();

    public virtual ICollection<Ordershipaddresslog> Ordershipaddresslogs { get; set; } = new List<Ordershipaddresslog>();

    public virtual ICollection<Ordersjobitem> Ordersjobitems { get; set; } = new List<Ordersjobitem>();

    public virtual ICollection<Ordersshipment> Ordersshipments { get; set; } = new List<Ordersshipment>();

    public virtual Warehouse Wh { get; set; } = null!;
}
