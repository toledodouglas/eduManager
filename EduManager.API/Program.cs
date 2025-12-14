using EduManager.Infrastructure.Data;
using EduManager.Infrastructure.Repositories; 
using EduManager.Domain.Interfaces;           

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuração do Entity Framework Core com SQLite
builder.Services.AddDbContext<EduContext>(options =>
    options.UseSqlite("Data Source=edumanager.db"));

// INJEÇÃO DE DEPENDÊNCIA 
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();
builder.Services.AddScoped<IDirectorRepository, DirectorRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();

app.Run();