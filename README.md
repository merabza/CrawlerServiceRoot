# CrawlerServiceRoot

Domain entities and application abstractions of [CrawlerService](https://github.com/merabza/CrawlerService).

| Project | Purpose |
|---|---|
| `CrawlerServiceRoot.Domain` | EF Core entities of the crawler database, one folder per entity |
| `CrawlerServiceRoot.Application.Abstractions` | `ICrawlerServiceApplicationDbContext` — the `DbSet` abstraction consumed by repositories |

The concrete `DbContext` and entity configurations live in [CrawlerServiceDbPart](https://github.com/merabza/CrawlerServiceDbPart).

## Repository layout — sibling repos are required

Projects reference sibling clones by relative path (`..\..\SystemTools\...`), so the repositories must be cloned next to each other:

```
<root>\
├── CrawlerServiceRoot\      this repository (CrawlerServiceRoot.slnx lives here)
└── SystemTools\             shared libraries (merabza/SystemTools)
```

## Build

```powershell
dotnet build CrawlerServiceRoot.slnx
```

## License

[MIT](LICENSE)
