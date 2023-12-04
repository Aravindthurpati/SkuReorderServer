using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Whuser
{
    public int Uniqueid { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool? Isactive { get; set; }

    public DateTime Entrydate { get; set; }

    public int Entryuserid { get; set; }

    public DateTime? Modifieddate { get; set; }

    public int? Modifieduserid { get; set; }

    public string? Title { get; set; }

    public string? Empid { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? Picture { get; set; }

    public string? Usertype { get; set; }

    public bool Allclientsaccess { get; set; }

    public bool Allmodulesaccess { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Companyname { get; set; }

    public byte[]? Photo { get; set; }

    public string Timezone { get; set; } = null!;

    public string? Refreshtoken { get; set; }

    public DateTime? Refreshtokenexpirytime { get; set; }

    public bool Allwarehousesaccess { get; set; }

    public string? Passwordhash { get; set; }

    public virtual ICollection<Carriertype> Carriertypes { get; set; } = new List<Carriertype>();

    public virtual ICollection<Clientcartonsize> Clientcartonsizes { get; set; } = new List<Clientcartonsize>();

    public virtual ICollection<Clientshipmethod> ClientshipmethodEntryusers { get; set; } = new List<Clientshipmethod>();

    public virtual ICollection<Clientshipmethod> ClientshipmethodModifiedusers { get; set; } = new List<Clientshipmethod>();

    public virtual ICollection<Cyclecount> CyclecountEntryusers { get; set; } = new List<Cyclecount>();

    public virtual ICollection<Cyclecount> CyclecountModifiedusers { get; set; } = new List<Cyclecount>();

    public virtual ICollection<Cyclecounthistory> Cyclecounthistories { get; set; } = new List<Cyclecounthistory>();

    public virtual ICollection<Cyclecounttracking> CyclecounttrackingEntryusers { get; set; } = new List<Cyclecounttracking>();

    public virtual ICollection<Cyclecounttracking> CyclecounttrackingModifiedusers { get; set; } = new List<Cyclecounttracking>();

    public virtual ICollection<Gridfilter> Gridfilters { get; set; } = new List<Gridfilter>();

    public virtual ICollection<Integrationchannel> IntegrationchannelEntryusers { get; set; } = new List<Integrationchannel>();

    public virtual ICollection<Integrationchannel> IntegrationchannelModifiedusers { get; set; } = new List<Integrationchannel>();

    public virtual ICollection<Manifestcomment> Manifestcomments { get; set; } = new List<Manifestcomment>();

    public virtual ICollection<Order> OrderEntryusers { get; set; } = new List<Order>();

    public virtual ICollection<Order> OrderModifiedusers { get; set; } = new List<Order>();

    public virtual ICollection<Orderitemshistory> OrderitemshistoryPickedusers { get; set; } = new List<Orderitemshistory>();

    public virtual ICollection<Orderitemshistory> OrderitemshistoryQcusers { get; set; } = new List<Orderitemshistory>();

    public virtual ICollection<Orderprocessjob> Orderprocessjobs { get; set; } = new List<Orderprocessjob>();

    public virtual ICollection<Ordershipaddresslog> Ordershipaddresslogs { get; set; } = new List<Ordershipaddresslog>();

    public virtual ICollection<Ordersjob> OrdersjobEntryusers { get; set; } = new List<Ordersjob>();

    public virtual ICollection<Ordersjob> OrdersjobModifiedusers { get; set; } = new List<Ordersjob>();

    public virtual ICollection<Ordersjobitem> Ordersjobitems { get; set; } = new List<Ordersjobitem>();

    public virtual ICollection<Passwordreset> Passwordresets { get; set; } = new List<Passwordreset>();

    public virtual ICollection<Robilling> RobillingEntryusers { get; set; } = new List<Robilling>();

    public virtual ICollection<Robilling> RobillingModifiedusers { get; set; } = new List<Robilling>();

    public virtual ICollection<Roreceiving> RoreceivingCompletedusers { get; set; } = new List<Roreceiving>();

    public virtual ICollection<Roreceiving> RoreceivingEntryusers { get; set; } = new List<Roreceiving>();

    public virtual ICollection<Roreceivinghistory> RoreceivinghistoryEntryusers { get; set; } = new List<Roreceivinghistory>();

    public virtual ICollection<Roreceivinghistory> RoreceivinghistoryModifiedusers { get; set; } = new List<Roreceivinghistory>();

    public virtual ICollection<Saleschannelmapping> Saleschannelmappings { get; set; } = new List<Saleschannelmapping>();

    public virtual ICollection<Sku> SkuEntryusers { get; set; } = new List<Sku>();

    public virtual ICollection<Sku> SkuModifiedusers { get; set; } = new List<Sku>();

    public virtual ICollection<Skuautofill> SkuautofillEntryusers { get; set; } = new List<Skuautofill>();

    public virtual ICollection<Skuautofill> SkuautofillModifiedusers { get; set; } = new List<Skuautofill>();

    public virtual ICollection<Skubarcode> SkubarcodeEntryusers { get; set; } = new List<Skubarcode>();

    public virtual ICollection<Skubarcode> SkubarcodeModifiedusers { get; set; } = new List<Skubarcode>();

    public virtual ICollection<Skuinventorylocation> SkuinventorylocationEntryusers { get; set; } = new List<Skuinventorylocation>();

    public virtual ICollection<Skuinventorylocation> SkuinventorylocationModifiedusers { get; set; } = new List<Skuinventorylocation>();

    public virtual ICollection<Skukitmapping> SkukitmappingEntryusers { get; set; } = new List<Skukitmapping>();

    public virtual ICollection<Skukitmapping> SkukitmappingModifiedusers { get; set; } = new List<Skukitmapping>();

    public virtual ICollection<Skupackage> SkupackageEntryusers { get; set; } = new List<Skupackage>();

    public virtual ICollection<Skupackage> SkupackageModifiedusers { get; set; } = new List<Skupackage>();

    public virtual ICollection<Warehouse> Warehouses { get; set; } = new List<Warehouse>();

    public virtual ICollection<Whclient> WhclientEntryusers { get; set; } = new List<Whclient>();

    public virtual ICollection<Whclient> WhclientModifiedusers { get; set; } = new List<Whclient>();

    public virtual ICollection<Whlocation> WhlocationEntryusers { get; set; } = new List<Whlocation>();

    public virtual ICollection<Whlocation> WhlocationModifiedusers { get; set; } = new List<Whlocation>();

    public virtual ICollection<Whuserclient> WhuserclientCreatedusers { get; set; } = new List<Whuserclient>();

    public virtual ICollection<Whuserclient> WhuserclientModifiedusers { get; set; } = new List<Whuserclient>();

    public virtual ICollection<Whuserclient> WhuserclientUsers { get; set; } = new List<Whuserclient>();

    public virtual ICollection<Whusermodule> WhusermoduleCreatedusers { get; set; } = new List<Whusermodule>();

    public virtual ICollection<Whusermodule> WhusermoduleModifiedusers { get; set; } = new List<Whusermodule>();

    public virtual ICollection<Whusermodule> WhusermoduleUsers { get; set; } = new List<Whusermodule>();

    public virtual ICollection<Whuserrefreshtoken> Whuserrefreshtokens { get; set; } = new List<Whuserrefreshtoken>();

    public virtual ICollection<Whuserwarehouse> WhuserwarehouseCreatedusers { get; set; } = new List<Whuserwarehouse>();

    public virtual ICollection<Whuserwarehouse> WhuserwarehouseModifiedusers { get; set; } = new List<Whuserwarehouse>();

    public virtual ICollection<Whuserwarehouse> WhuserwarehouseUsers { get; set; } = new List<Whuserwarehouse>();
}
