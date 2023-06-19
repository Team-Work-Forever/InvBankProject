﻿

namespace InvBank.Backend.Domain.Entities;

public partial class PaymentProperty
{
    public Guid Id { get; set; }

    public Guid AtiveId { get; set; }

    public DateOnly PaymentDate { get; set; }

    public decimal Amount { get; set; }

    public virtual ActivesProperty Ative { get; set; } = null!;
}
