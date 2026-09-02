// ReSharper disable CollectionNeverUpdated.Global

using System.Collections.Generic;
using CrawlerServiceRoot.Domain.TaskStartPoints;
using SystemTools.SystemToolsShared;

namespace CrawlerServiceRoot.Domain.TaskModels;

public sealed class TaskModel : ItemData
{
    public int TaskId { get; init; }
    public required string TaskName { get; init; }
    public ICollection<TaskStartPoint> StartPoints { get; init; } = new HashSet<TaskStartPoint>();
}
