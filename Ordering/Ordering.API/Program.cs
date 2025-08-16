using Ordering.Application;
using Ordering.Infrastructure;
using Ordering.API;

var builder = WebApplication.CreateBuilder(args);

//Add Services to the container
builder.Services
    .AddApplicationServices()
    .AddInfrastuctureServices(builder.Configuration)
    .AddApiServices();





var app = builder.Build();

//configure the HTTp request pipeline.

app.Run();
