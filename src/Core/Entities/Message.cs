namespace Core.Entities;

public class Message : BaseEntity
{
    public Guid SenderId { get; set; }
    public Guid ReceiverId { get; set; }
    public Guid? FileId { get; set; }
    public Guid? ParentMessageId { get; set; }
    public string? Subject { get; set; }
    public string Body { get; set; } = string.Empty;
    public bool IsRead { get; set; }
    public DateTime? ReadAt { get; set; }
    public bool DeletedBySender { get; set; }
    public bool DeletedByReceiver { get; set; }

    public User Sender { get; set; } = null!;
    public User Receiver { get; set; } = null!;
    public File? File { get; set; }
    public Message? ParentMessage { get; set; }
    public ICollection<Message> Replies { get; set; } = new List<Message>();
}
