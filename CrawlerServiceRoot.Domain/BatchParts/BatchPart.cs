// ReSharper disable CollectionNeverUpdated.Global

using System;
using System.Collections.Generic;
using CrawlerServiceRoot.Domain.Batches;
using CrawlerServiceRoot.Domain.ContentsAnalysis;
using CrawlerServiceRoot.Domain.Robots;
using CrawlerServiceRoot.Domain.TermsByUrls;
using CrawlerServiceRoot.Domain.UrlGraphNodes;

namespace CrawlerServiceRoot.Domain.BatchParts;

public sealed class BatchPart
{
    private Batch? _batchNavigation;

    public int BpId { get; set; }
    public int BatchId { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Finished { get; set; }

    public Batch BatchNavigation
    {
        get =>
            _batchNavigation ??
            throw new InvalidOperationException("Uninitialized property: " + nameof(BatchNavigation));
        set => _batchNavigation = value;
    }

    public ICollection<UrlGraphNode> UrlGraphNodes { get; set; } = new HashSet<UrlGraphNode>();
    public ICollection<TermByUrl> TermsByUrls { get; set; } = new HashSet<TermByUrl>();
    public ICollection<ContentAnalysis> ContentsAnalysis { get; set; } = new HashSet<ContentAnalysis>();
    public ICollection<Robot> Robots { get; set; } = new HashSet<Robot>();
}
