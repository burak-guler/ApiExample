var builder = WebApplication.CreateBuilder(args);

//service (container)

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//development mod da ise swagger kullanýlýr deðilse kullanýlmaz
//development olup olmadýýný launchSetting.json dan bakabilirsin.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.MapControllers();

app.Run();
