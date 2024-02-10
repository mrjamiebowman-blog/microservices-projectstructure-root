var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedisContainer("cache");

//var apiservice = builder.AddProject<Projects.MrJB.Solution.Aspire_ApiService>("apiservice");

//builder.AddProject<Projects.MrJB.Solution.Aspire_Web>("webfrontend")
//    .WithReference(cache)
//    .WithReference(apiservice);

builder.Build().Run();
