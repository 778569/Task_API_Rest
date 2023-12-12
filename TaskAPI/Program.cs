using TaskAPI.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        //builder.Services.Register();
        builder.Services.AddScoped<TodoService, TodoService>();
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