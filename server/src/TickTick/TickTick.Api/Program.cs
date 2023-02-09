using Microsoft.OpenApi.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.AddSwaggerGen(config =>
        {
            config.SwaggerDoc(
                "v1",
                new OpenApiInfo
                {
                    Title = "TickTick your ticks and tickles",
                    Version = "v1",
                    Description = "lorem ipsim sit dolar amet",
                    Contact = new OpenApiContact
                    {
                        Name = "Kevin DeRudder",
                        Email = "kevin.derudder@gmail.com",
                        Url = new Uri("https://chat.opeanai.com")
                    }
                });
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.

        app.UseHttpsRedirection();
        if (app.Environment.IsDevelopment()) {
            app.UseSwagger();
            app.UseSwaggerUI();
        }


        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}