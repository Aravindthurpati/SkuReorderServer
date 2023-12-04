using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Sku
{
    public int Skuid { get; set; }

    public string Sku1 { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Status { get; set; } = null!;

    public double Weight { get; set; }

    public int Reorderpoint { get; set; }

    public decimal Purchasecost { get; set; }

    public string Itemtype { get; set; } = null!;

    public int? Maxorderqty { get; set; }

    public int Entryuserid { get; set; }

    public DateTime Entrydate { get; set; }

    public int Modifieduserid { get; set; }

    public DateTime Modifieddate { get; set; }

    public int? Minorderqty { get; set; }

    public string Uom { get; set; } = null!;

    public bool Islotcode { get; set; }

    public bool Isexpdate { get; set; }

    public bool Isserialno { get; set; }

    public string? Hsncode { get; set; }

    public string? Mpncode { get; set; }

    public string? Gtin { get; set; }

    public int Expdays { get; set; }

    public int Clientid { get; set; }

    public double? Sellcost { get; set; }

    public int? Safetystock { get; set; }

    public string? Imageurl { get; set; }

    public string? Alternateitemcode { get; set; }

    public string? Alternateitemdescription { get; set; }

    public string? Itemcategory { get; set; }

    public string? Subitemcategory { get; set; }

    public string? Storagetype { get; set; }

    public bool Iscyclecount { get; set; }

    public string? Expyears { get; set; }

    public string? Manufacturervendor { get; set; }

    public bool Ishazmat { get; set; }

    public string? Hazmat { get; set; }

    public string? Cyclemonths { get; set; }

    public bool Iskititem { get; set; }

    public bool Isoversize { get; set; }

    public int? Originid { get; set; }

    public byte[]? Photo { get; set; }

    public bool Isfastmoving { get; set; }

    public virtual ICollection<Batchingitem> Batchingitems { get; set; } = new List<Batchingitem>();

    public virtual Whclient Client { get; set; } = null!;

    public virtual ICollection<Cyclecounthistory> Cyclecounthistories { get; set; } = new List<Cyclecounthistory>();

    public virtual Whuser Entryuser { get; set; } = null!;

    public virtual Whuser Modifieduser { get; set; } = null!;

    public virtual ICollection<Orderitem> Orderitems { get; set; } = new List<Orderitem>();

    public virtual ICollection<Orderitemshistory> Orderitemshistories { get; set; } = new List<Orderitemshistory>();

    public virtual ICollection<Orderitemstmp> Orderitemstmps { get; set; } = new List<Orderitemstmp>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Country? Origin { get; set; }

    public virtual ICollection<Roreceivingdetail> Roreceivingdetails { get; set; } = new List<Roreceivingdetail>();

    public virtual ICollection<Skuautofill> Skuautofills { get; set; } = new List<Skuautofill>();

    public virtual ICollection<Skubarcode> Skubarcodes { get; set; } = new List<Skubarcode>();

    public virtual ICollection<Skuinventorylocationlog> Skuinventorylocationlogs { get; set; } = new List<Skuinventorylocationlog>();

    public virtual ICollection<Skuinventorylocation> Skuinventorylocations { get; set; } = new List<Skuinventorylocation>();

    public virtual ICollection<Skukitmapping> SkukitmappingComponentskus { get; set; } = new List<Skukitmapping>();

    public virtual ICollection<Skukitmapping> SkukitmappingKitskus { get; set; } = new List<Skukitmapping>();

    public virtual ICollection<Skupackage> Skupackages { get; set; } = new List<Skupackage>();
}
