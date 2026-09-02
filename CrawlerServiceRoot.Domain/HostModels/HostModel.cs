// ReSharper disable CollectionNeverUpdated.Global

using System.Collections.Generic;
using CrawlerServiceRoot.Domain.HostsByBatches;
using CrawlerServiceRoot.Domain.Robots;
using CrawlerServiceRoot.Domain.UrlModels;
using SystemTools.SystemToolsShared;

namespace CrawlerServiceRoot.Domain.HostModels;

public sealed class HostModel : ItemData
{
    public int HostId { get; set; }
    public required string HostName { get; set; }
    public bool HostProhibited { get; set; }

    public ICollection<UrlModel> Urls { get; set; } = new HashSet<UrlModel>();
    public ICollection<HostByBatch> HostsByBatches { get; set; } = new HashSet<HostByBatch>();
    public ICollection<Robot> Robots { get; set; } = new HashSet<Robot>();
}
