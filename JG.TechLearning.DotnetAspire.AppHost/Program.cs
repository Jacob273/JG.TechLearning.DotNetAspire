var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

var apiService = builder.AddProject<Projects.JG_TechLearning_DotnetAspire_ApiService>("apiservice");

builder.AddProject<Projects.JG_TechLearning_DotnetAspire_Web>("webfrontend")
    .WithReference(cache)
    .WithReference(apiService);

builder.Build().Run();
