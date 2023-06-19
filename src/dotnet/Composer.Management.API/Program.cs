using Nest;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IElasticClient, ElasticClient>((factory) =>
{
    var settings = new ConnectionSettings(new Uri("https://localhost:9200"))
        .CertificateFingerprint("55:A5:EF:61:75:F0:F9:D9:CC:39:A2:2E:5F:49:29:B6:43:ED:15:4F:EA:FD:D9:8A:B3:AD:F6:04:37:5D:3D:1B")
        .BasicAuthentication("elastic", "#VtgdV0*}!hFbU41");
    
    var client = new ElasticClient(settings);

    return client;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
