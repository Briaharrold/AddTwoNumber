
using AddTwoNumber.Services.MinichOne;
using AddTwoNumber.Services.MinichThree;
using AddTwoNumber.Services.MinichTwo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAddTwoNumbersService, AddTwoNumbersService>();
builder.Services.AddScoped<IGreaterThanOrLessThanService, GreaterThanOrLessThanService>();
builder.Services.AddScoped<IAskingQuestionsService, AskingQuestionsService>();
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
