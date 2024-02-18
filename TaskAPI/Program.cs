using TaskAPI.DataAccess;
using TaskAPI.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
     
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        //builder.Services.Register();
        //builder.Services.AddScoped<TodoService, TodoService>();

        //builder.Services.AddScoped<ITodoRepository, TodoService>();
        builder.Services.AddDbContext<TodoDbContext>();

        builder.Services.AddScoped<ITodoRepository, TodoSQLServerService>();



        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();


        //void Configure(IApplicationBuilder app)
        //{
        //    app.Run(async (context) =>
        //    {
        //        await context.Response.WriteAsync("Hello World");
        //    });
        //}
        //app.Run(handler: async context =>
        //{
        //    await context.Response.WriteAsync(text: "Hello world");
        //});

        app.Run();
    }
}