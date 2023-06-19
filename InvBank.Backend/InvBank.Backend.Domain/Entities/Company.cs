﻿

namespace InvBank.Backend.Domain.Entities;

public partial class Company
{
    public Guid Id { get; set; }

    public string CompanyName { get; set; } = null!;

    public string Nif { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public DateOnly CreatedAt { get; set; }

    public DateOnly UpdatedAt { get; set; }

    public DateOnly? DeletedAt { get; set; }

    public virtual Auth IdNavigation { get; set; } = null!;
}
