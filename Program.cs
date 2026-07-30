using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Citas_Medicas.Modules;
using Citas_Medicas.Data;
using Citas_Medicas.Modules.Citas;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddCitasModule();

builder.Services.AddDbContext<AppDbContext>(options =>{
    options.UseNpgsql(
    builder.Configuration.GetConnectionString("PostgresConnection"));
});

var app = builder.Build();

app.MapControllers();
app.Run();

