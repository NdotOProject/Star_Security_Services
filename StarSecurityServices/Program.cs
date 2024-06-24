using Microsoft.EntityFrameworkCore;
using StarSecurityServices.Context;
using StarSecurityServices.DTOs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOptions();

builder.Services.AddSingleton(builder.Configuration);

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddHttpContextAccessor();

builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("Default")
    )
);

builder.Services.AddSingleton(sp => {
    var dbContext = sp.GetRequiredService<ApplicationDbContext>();

    return new Mappers(dbContext);
});

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    using (var serviceScope = app.Services?.GetService<IServiceScopeFactory>()?.CreateScope())
    {
        var context = serviceScope?.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        context?.Database.EnsureCreated();
    }

    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
