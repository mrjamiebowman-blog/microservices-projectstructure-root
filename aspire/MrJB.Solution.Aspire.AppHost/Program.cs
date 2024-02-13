var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedisContainer("cache");

//var apiservice = builder.AddProject<Projects.MrJB_Solution_Api>("api");

//builder.AddProject<Projects.MrJB_Solution_Web>("web")
//    .WithReference(cache)
//    .WithReference(apiservice);

builder.Build().Run();
