namespace LocalIdentity.SimpleInfra.Domain.Common.Query;
/// <summary>
///  Defines conversion functionality to query specification.
/// </summary>
public interface IQueryConvertible<TSource>
{
    /// <summary>
    /// Converts to query specification
    /// </summary>
    QuerySpecification<TSource> ToQuerySpecification();
}