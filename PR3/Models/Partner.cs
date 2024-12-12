using System;
using System.Collections.Generic;

namespace PR3.Models;

public partial class Partner
{
    public int Id { get; set; }

    public short IdTypeOfPartner { get; set; }

    public string Name { get; set; } = null!;

    public string Adress { get; set; } = null!;

    public string Inn { get; set; } = null!;

    public string DirectorFullName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public short? Rating { get; set; }

    public virtual TypesOfPartner IdTypeOfPartnerNavigation { get; set; } = null!;

    public virtual ICollection<PartnersProduct> PartnersProducts { get; set; } = new List<PartnersProduct>();
}
