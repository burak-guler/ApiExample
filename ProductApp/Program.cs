var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//SERV�S KAYDI YAPILIR
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//LOGG�NG YAPISI ���N  SERV�S KAYDI VE CONG�GURE GER�EKLE�T�R�YORUZ
//bunlar� bizim console de ve debug penceresinde loglar� g�rmek i�in yap�yoruz.
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.AddDebug();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
