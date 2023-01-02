using Amazon.DynamoDBv2.DataModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

//Best Practices
ConfigureDataServices(builder.Services);

void ConfigureDataServices(IServiceCollection services)
{   
    //se injecta el contexto de la base de datos. 
    services.AddSingleton<IDynamoDBContext, DynamoDBContext>();

}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
