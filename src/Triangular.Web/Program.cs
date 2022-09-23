using Microsoft.Net.Http.Headers;
using Triangular.Web.Interfaces;
using Triangular.Web.Services;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("https://localhost:7215",
                                              "http://localhost:5215")
                                .AllowAnyHeader()
                                .AllowAnyMethod();
                      });
});

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<Triangular.Web.StateService.StateGridService>();
builder.Services.AddHttpClient("Triangle", httpClient =>
{
    httpClient.BaseAddress = new Uri("https://localhost:7215/");
    httpClient.DefaultRequestHeaders.Add(
        HeaderNames.Accept, "application/json");
}
);
builder.Services.AddScoped(typeof(ITriangleClient<,>), typeof(TriangleClientService<,>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseCors(MyAllowSpecificOrigins);

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
