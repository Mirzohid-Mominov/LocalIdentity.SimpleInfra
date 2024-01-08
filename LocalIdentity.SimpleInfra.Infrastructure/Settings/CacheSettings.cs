namespace LocalIdentity.SimpleInfra.Infrastructure.Settings;

public class CacheSettings
{
    public int AbsoluteExpirationInSeconds { get; set; }

    public int SlidingExpirationInSeconds { get; set; }
}