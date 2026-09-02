using CrawlerServiceRoot.Domain.Batches;
using CrawlerServiceRoot.Domain.BatchParts;
using CrawlerServiceRoot.Domain.ContentsAnalysis;
using CrawlerServiceRoot.Domain.ExtensionModels;
using CrawlerServiceRoot.Domain.HostModels;
using CrawlerServiceRoot.Domain.HostsByBatches;
using CrawlerServiceRoot.Domain.Robots;
using CrawlerServiceRoot.Domain.SchemeModels;
using CrawlerServiceRoot.Domain.TaskModels;
using CrawlerServiceRoot.Domain.TaskStartPoints;
using CrawlerServiceRoot.Domain.Terms;
using CrawlerServiceRoot.Domain.TermsByUrls;
using CrawlerServiceRoot.Domain.TermTypes;
using CrawlerServiceRoot.Domain.UrlGraphNodes;
using CrawlerServiceRoot.Domain.UrlModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;

namespace CrawlerServiceRoot.Application.Abstractions;

//ბაზაში არსებული ცხრილები წარმოდგენილი DbSet-ების სახით და ის ოპერაციები,
//რომლებსაც რეპოზიტორიები კონტექსტისგან ითხოვენ
public interface ICrawlerServiceApplicationDbContext
{
    DbSet<Batch> Batches { get; }
    DbSet<BatchPart> BatchParts { get; }
    DbSet<ContentAnalysis> ContentsAnalysis { get; }
    DbSet<ExtensionModel> Extensions { get; }
    DbSet<HostByBatch> HostsByBatches { get; }
    DbSet<HostModel> Hosts { get; }
    DbSet<Robot> Robots { get; }
    DbSet<SchemeModel> Schemes { get; }
    DbSet<TaskModel> Tasks { get; }
    DbSet<TaskStartPoint> TaskStartPoints { get; }
    DbSet<Term> Terms { get; }
    DbSet<TermByUrl> TermsByUrls { get; }
    DbSet<TermType> TermTypes { get; }
    DbSet<UrlGraphNode> UrlGraphNodes { get; }
    DbSet<UrlModel> Urls { get; }

    int SaveChanges();
    IDbContextTransaction BeginTransaction();
    EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    EntityEntry<TEntity> Update<TEntity>(TEntity entity) where TEntity : class;
}
