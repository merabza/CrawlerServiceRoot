// ReSharper disable CollectionNeverUpdated.Global

using System.Collections.Generic;
using CrawlerServiceRoot.Domain.BatchParts;
using CrawlerServiceRoot.Domain.HostsByBatches;
using SystemTools.SystemToolsShared;

namespace CrawlerServiceRoot.Domain.Batches;

public sealed class Batch : ItemData
{
    public int BatchId { get; set; }
    public required string BatchName { get; set; }
    public bool IsOpen { get; set; }
    public bool AutoCreateNextPart { get; set; }

    public ICollection<HostByBatch> HostsByBatches { get; set; } = new HashSet<HostByBatch>();
    public ICollection<BatchPart> BatchParts { get; set; } = new HashSet<BatchPart>();
}
