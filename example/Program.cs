using Cord.SDK;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddCordSdk(opt =>
{
    opt.ApplicationId = "45469abc-8288-4160-a8c3-bea9b7f07693";
    opt.Secret = "e8786affb8466c3f0d937f6dcd37cde3b30fe1ba301122d2bde2f025c31b3bee";
});

var app = builder.Build();
app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();
app.MapGet("/", () => "Hello World!");

app.Run();