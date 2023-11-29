var builder = DistributedApplication.CreateBuilder(args);

var redis = builder.AddRedisContainer("redisDocker");

var backend = builder.AddProject<Projects.NetAspire_API>("aspireapi");

builder.AddProject<Projects.NetAspire_Web>("frontend")
    .WithReference(backend)
    .WithReference(redis);

builder.Build().Run();
