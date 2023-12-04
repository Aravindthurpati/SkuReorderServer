using System;
using System.Collections.Generic;

namespace SkuReorderService.Models;

public partial class Roreceiving
{
    public string Ronumber { get; set; } = null!;

    public DateTime? Rodate { get; set; }

    public short Roclosed { get; set; }

    public int Entryuserid { get; set; }

    public short Roacknowledged { get; set; }

    public DateTime? Roacknowledgdate { get; set; }

    public string? Comments { get; set; }

    public string? Rofilename { get; set; }

    public int Clientid { get; set; }

    public int Uniqueid { get; set; }

    public string? Postatus { get; set; }

    public DateTime Createddate { get; set; }

    public DateOnly? Schdate { get; set; }

    public TimeOnly? Schtime { get; set; }

    public string? Waittime { get; set; }

    public int? Createduserid { get; set; }

    public bool Isrescheduled { get; set; }

    public TimeOnly? Starttime { get; set; }

    public TimeOnly? Endtime { get; set; }

    public DateTime? Modifieddate { get; set; }

    public int Slahrs { get; set; }

    public string? Previousstatus { get; set; }

    public bool Floorloaded { get; set; }

    public bool Palletized { get; set; }

    public bool Issamesku { get; set; }

    public int? Whid { get; set; }

    public int Noofboxes { get; set; }

    public int Noofpallets { get; set; }

    public bool Ismailsent { get; set; }

    public int? Completeduserid { get; set; }

    public DateTime? Completeddate { get; set; }

    public DateTime? Finalizeddate { get; set; }

    public int? Totalunits { get; set; }

    public int? Totalreceived { get; set; }

    public int? Totalexpected { get; set; }

    public string? Containertype { get; set; }

    public double? Weight { get; set; }

    public double? Volume { get; set; }

    public string? Containerid { get; set; }

    public int? Productcount { get; set; }

    public string? Goodshandlinginstructions { get; set; }

    public int? Totallineplts { get; set; }

    public string? Docketid { get; set; }

    public string? Receiveref { get; set; }

    public string? Supplier { get; set; }

    public string? Transportco { get; set; }

    public DateTime? Bookingdate { get; set; }

    public string? Eta { get; set; }

    public string? Porteta { get; set; }

    public string? Portlfd { get; set; }

    public string? Portappt { get; set; }

    public string? Deliveryapptglcd { get; set; }

    public DateTime? Arrivaldate { get; set; }

    public string? Lfdtoreturn { get; set; }

    public string? Portappttoreturn { get; set; }

    public int? Palletseries { get; set; }

    public DateTime? Unloaddate { get; set; }

    public DateTime? Returnnotified { get; set; }

    public DateTime? Emptypickedup { get; set; }

    public DateTime? Returned { get; set; }

    public virtual Whclient Client { get; set; } = null!;

    public virtual Whuser? Completeduser { get; set; }

    public virtual Whuser Entryuser { get; set; } = null!;

    public virtual ICollection<Robilling> Robillings { get; set; } = new List<Robilling>();

    public virtual ICollection<Roreceivingdetail> Roreceivingdetails { get; set; } = new List<Roreceivingdetail>();

    public virtual ICollection<Rotracking> Rotrackings { get; set; } = new List<Rotracking>();
}
