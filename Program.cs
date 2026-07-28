using Microsoft.AspNetCore.Mvc;
using Citas_Medicas.Modules.Citas.DTOS;
using Citas_Medicas.Modules.Citas.Services;
using Citas_Medicas.Modules.Citas;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddCitasModule();
var app = builder.Build();

app.MapControllers();
app.Run();

