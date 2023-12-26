using LocalIdentity.SimpleInfra.Domain.Entities;
using LocalIdentity.SimpleInfra.Domain.Enums;

namespace LocalIdentity.SimpleInfra.Application.Common.Notifications.Events;

public class RenderNotificationEvent : NotificationEvent
{
    public NotificationTemplate Template { get; init; } = default!;
    
    public User SenderUser { get; set; } = default!;
    
    public User ReceiverUser { get; set; } = default!;

    public Dictionary<string, string> Variables { get; set; } = new();
}