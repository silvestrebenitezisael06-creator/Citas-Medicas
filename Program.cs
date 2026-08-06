using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Citas_Medicas.Modules;
using Citas_Medicas.Data;
using Citas_Medicas.Modules.Citas;
using Citas_Medicas.Modules.Medicos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddCitasModule();
builder.Services.AddMedicoModule();

builder.Services.AddDbContext<AppDbContext>(options =>{
    options.UseNpgsql(
    builder.Configuration.GetConnectionString("PostgresConnection"));
});

var app = builder.Build();

app.MapControllers();
app.Run();

