using System;
using System.Collections.Generic;

namespace PR3.Models;

public partial class TypesOfPartner
{
    public string TypeOfPartner { get; set; } = null!;

    public short Id { get; set; }

    public virtual ICollection<Partner> Partners { get; set; } = new List<Partner>();
}
