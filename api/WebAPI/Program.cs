using WebAPI.Controllers;
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

//init with test datastore since not creating functioning datastore
IExcerciseDatastore excerciseDatastore = new TestExcerciseDatastore();
ApiController apiController = new ApiController(excerciseDatastore);

app.MapGet("/randomExcercise", () =>
{
    return apiController.GetRandomExcercise();;
})
.WithName("GetRandomExcercise")
.WithOpenApi();

app.MapGet("/AllExcercises", () =>
{
    return apiController.GetAllExcercises();;
})
.WithName("GetAllExcercises")
.WithOpenApi();

app.MapGet("/randomSchedule", () =>
{
    return apiController.GetRandomSchedule();;
})
.WithName("GetRandomSchedule")
.WithOpenApi();

app.Run();

