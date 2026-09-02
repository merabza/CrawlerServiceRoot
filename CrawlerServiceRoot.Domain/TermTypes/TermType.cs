// ReSharper disable CollectionNeverUpdated.Global

using System.Collections.Generic;
using CrawlerServiceRoot.Domain.Terms;

namespace CrawlerServiceRoot.Domain.TermTypes;

public sealed class TermType
{
    public int TtId { get; set; }
    public required string TtKey { get; set; }
    public string? TtName { get; set; }

    public ICollection<Term> Terms { get; set; } = new HashSet<Term>();
}
