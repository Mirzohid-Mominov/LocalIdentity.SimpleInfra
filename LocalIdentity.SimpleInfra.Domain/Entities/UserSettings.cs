using LocalIdentity.SimpleInfra.Domain.Common.Entities;
using LocalIdentity.SimpleInfra.Domain.Enums;

namespace LocalIdentity.SimpleInfra.Domain.Entities;

public class UserSettings : Entity
{
    public NotificationType? PrefferedNotificationType { get; set; }
    
    /// <summary>
    /// Gets or sets the user id
    /// </summary>
    public Guid Id { get; set; }
}