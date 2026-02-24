using Core.Enums;

namespace Core.Entities;

public class Payment : BaseEntity
{
    public Guid FileId { get; set; }
    public decimal Amount { get; set; }
    public string Currency { get; set; } = "EUR";
    public DateOnly? PaymentDate { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public Guid? ReceiptDocumentId { get; set; }
    public PaymentStatus Status { get; set; } = PaymentStatus.Pending;
    public Guid? ValidatedBy { get; set; }
    public DateTime? ValidatedAt { get; set; }
    public string? RejectionReason { get; set; }
    public string? ReferenceNumber { get; set; }
    public string? Notes { get; set; }
}
