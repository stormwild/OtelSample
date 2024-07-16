var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddOpenTelemetry()
       .ConfigureResource((resource) =>
       {
           resource.AddService(builder.Configuration["Otel:ServiceName"]);
       })
       .WithMetrics((builder, metrics) =>
       {
           /* metrics.AddMeter(
            "Microsoft.AspNetCore.Hosting",
            "Microsoft.AspNetCore.Server.Kestrel",
            "System.Net.Http"); */
           metrics
            .AddAspNetCoreInstrumentation()
            .AddHttpClientInstrumentation();

           metrics.AddOtlpExporter();
       })
       .WithTracing(tracing =>
       {
           tracing
                .AddAspNetCoreInstrumentation()
                .AddHttpClientInstrumentation();

           tracing
                .AddOtlpExporter();
       });

builder.Logging.AddOpenTelemetry(options =>
{
    options.IncludeScopes = true;
    options.IncludeFormattedMessage = true;
    options.AddOtlpExporter();
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
