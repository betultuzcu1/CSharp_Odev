var Builder = WebApplication.CreateBuilder(args);

//services
Builder.Services.AddMvc();

//apps

var app=Builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
}
);

app.Run();