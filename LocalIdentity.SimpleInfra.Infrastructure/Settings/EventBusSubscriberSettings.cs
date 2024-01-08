namespace LocalIdentity.SimpleInfra.Infrastructure.Settings;

public abstract class EventBusSubscriberSettings
{
    public ushort PrefetchCount { get; set; }
}