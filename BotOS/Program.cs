var builder = WebApplication.CreateBuilder(args);
AddServices(builder.Services);

var app = builder.Build();
Configure(app, app.Environment, app.Lifetime);

app.Run();


// Add services to the container.
void AddServices(IServiceCollection services)
{
    services.AddControllers();
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();
}

// Configure request pipeline
void Configure(IApplicationBuilder app, IHostEnvironment env, IHostApplicationLifetime lifetime)
{
    if (env.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseRouting();
    app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
}
