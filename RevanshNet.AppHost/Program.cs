var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.RevMVC>("revmvc");

builder.AddProject<Projects.ReactRev_Server>("reactrev-server");

builder.Build().Run();
