using API.Data;
using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        //make a web applikation instance

        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.AddDbContext<DataContext>(opt=>{
            opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
        });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();//זה אין לו בפרויקט
        builder.Services.AddSwaggerGen();//זה אין לו בפרויקט

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }//זה אין לו בפרויקט

        app.UseHttpsRedirection();//זה אין לו בפרויקט

        app.UseAuthorization();//זה אין לו בפרויקט

        app.MapControllers();

        app.Run();
    }
}