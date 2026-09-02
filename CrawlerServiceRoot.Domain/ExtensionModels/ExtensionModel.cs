using System.Collections.Generic;
using CrawlerServiceRoot.Domain.UrlModels;

namespace CrawlerServiceRoot.Domain.ExtensionModels;

public sealed class ExtensionModel
{
    public int ExtId { get; set; }
    public required string ExtName { get; set; }
    public bool ExtProhibited { get; set; }

    public ICollection<UrlModel> Urls { get; set; } = new HashSet<UrlModel>();
}
