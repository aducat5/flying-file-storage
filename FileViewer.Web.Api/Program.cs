using FileViewer.Service;
using FileViewer.Service.DBConnection;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<FileStorageDBSettings>(builder.Configuration.GetSection(nameof(FileStorageDBSettings)));
builder.Services.AddSingleton<IFileStorageDBSettings>(sp => sp.GetRequiredService<IOptions<FileStorageDBSettings>>().Value);
builder.Services.AddScoped<FileService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbucklez
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//enabling cors for client app
builder.Services.AddCors(o => o.AddPolicy("LowCorsPolicy", builder => {
    builder.AllowAnyOrigin()
       .AllowAnyMethod()
       .AllowAnyHeader();
}));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//use the new cors policy
app.UseCors("LowCorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
