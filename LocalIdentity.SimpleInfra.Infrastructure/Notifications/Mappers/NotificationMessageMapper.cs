using AutoMapper;
using LocalIdentity.SimpleInfra.Application.Common.Notifications.Models;

namespace LocalIdentity.SimpleInfra.Infrastructure.Notifications.Mappers;

public class NotificationMessageMapper : Profile
{
    public NotificationMessageMapper()
    {
        CreateMap<EmailProcessNotificationEvent, EmailMessage>();
    }
}