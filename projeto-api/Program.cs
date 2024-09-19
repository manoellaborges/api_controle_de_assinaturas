using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Configurando DbContext para PostgreSQL
builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

//Configurando Repositórios e Serviços
builder.Services.AddScoped<IControleDeAssinaturasRepository, ControleDeAssinaturasRepository>();
builder.Services.AddScoped<IControleDeAssinaturasServices, ControleDeAssinaturasServices>();    

//Adicionando controladores
builder.Services.AddControllers();

//Adicionando Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();