var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//SERVÝS KAYDI YAPILIR
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//LOGGÝNG YAPISI ÝÇÝN  SERVÝS KAYDI VE CONGÝGURE GERÇEKLEÞTÝRÝYORUZ
//bunlarý bizim console de ve debug penceresinde loglarý görmek için yapýyoruz.
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
