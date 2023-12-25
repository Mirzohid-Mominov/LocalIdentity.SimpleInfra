namespace LocalIdentity.SimpleInfra.Domain.Common.Caching;
/// <summary>
///     Defines cache model properties
/// </summary>
public interface ICacheModel
{
    /// <summary>
    /// gets computed cache key.
    /// </summary>
    string CacheKey { get; }
}