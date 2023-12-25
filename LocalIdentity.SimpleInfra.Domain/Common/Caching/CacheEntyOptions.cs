namespace LocalIdentity.SimpleInfra.Domain.Common.Caching;

public class CacheEntyOptions
{
    public CacheEntyOptions()
    {
        
    }

    public CacheEntyOptions(TimeSpan? absoluteExpirationRelativeToNow, TimeSpan? slidingExpiration)
    {
        AbsoluteExpirationRelativeToNow = absoluteExpirationRelativeToNow;
        SlidingExpiration = slidingExpiration;
    }
    
    public TimeSpan? AbsoluteExpirationRelativeToNow { get; init; }
    public TimeSpan? SlidingExpiration { get; init; }
}