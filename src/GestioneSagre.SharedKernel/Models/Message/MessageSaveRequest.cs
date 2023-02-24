namespace GestioneSagre.SharedKernel.Models.Message;

public class MessageSaveRequest
{
    public Guid MessageId { get; set; }
    public string Recipient { get; set; }
    public string Subject { get; set; }
    public string Message { get; set; }
    public int SenderCount { get; set; }
    public MailStatus Status { get; set; }
}