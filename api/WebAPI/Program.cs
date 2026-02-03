using WebAPI.Interfaces;
using WebAPI.WebApi.Test;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


IExcerciseDatastore excerciseDatastore = new TestExcerciseDatastore();

app.MapGet("/randomExcercise", () =>
{
    return excerciseDatastore.GetRandomExcercise();;
})
.WithName("GetRandomExcercise")
.WithOpenApi();

app.MapGet("/AllExcercises", () =>
{
    return excerciseDatastore.GetAllExcercises();;
})
.WithName("GetAllExcercises")
.WithOpenApi();

app.MapGet("/randomSchedule", () =>
{
    return excerciseDatastore.GetRandomSchedule();;
})
.WithName("GetRandomSchedule")
.WithOpenApi();

app.Run();

