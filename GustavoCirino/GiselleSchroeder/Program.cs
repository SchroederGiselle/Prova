using GiselleSchroeder.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDataContext>();
var app = builder.Build();

app.MapGet("/", () => "AAAAA!");

app.MapPost("/api/funcionario/cadastrar", ([FromBody] Funcionario funcionario,  
    [FromServices] AppDataContext ctx) =>
{
    ctx.Funcionarios.Add(funcionario);
    ctx.SaveChanges();
    return Results.Created("", funcionario);
}); 

app.MapGet("/api/funcionario/listar" , ([FromServices] AppDataContext ctx) => 
{
    if(ctx.Funcionarios.Any())
    {
        return Results.Ok(ctx.Funcionarios.ToList());
    }
    return Results.NotFound();
});

app.MapPost("/api/folha/cadastrar", ([FromBody] Folha folha,  
    [FromServices] AppDataContext ctx) =>
{
    ctx.Folhas.Add(folha);
    ctx.SaveChanges();
    return Results.Created("", folha);
});

app.Run();
