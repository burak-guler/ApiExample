var builder = WebApplication.CreateBuilder(args);

//service (container)

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//development mod da ise swagger kullan�l�r de�ilse kullan�lmaz
//development olup olmad��n� launchSetting.json dan bakabilirsin.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.MapControllers();

app.Run();
