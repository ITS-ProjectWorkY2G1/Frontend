using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

IdentityModelEventSource.ShowPII = true;

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();
builder.Services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true; });

var _conf = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json", optional: false)
        .Build();

builder.Services.AddAuthentication(o =>
{
    o.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;

}).AddCookie(o =>
{
    o.LoginPath = "/login";
    o.ExpireTimeSpan = TimeSpan.FromDays(1);
    o.SlidingExpiration = false;
}).AddOpenIdConnect(options =>
{

    options.ClientId = "mudblazorTest";
    options.ClientSecret = "bf45541e-66ac-4acb-a495-ee6f96d971ab";

    options.RequireHttpsMetadata = false;
    options.GetClaimsFromUserInfoEndpoint = true;
    options.SaveTokens = true;

    options.ResponseType = OpenIdConnectResponseType.Code;
    options.AuthenticationMethod = OpenIdConnectRedirectBehavior.RedirectGet;

    options.Authority = _conf["AuthLink"];

    if (true)
    {
        HttpClientHandler handler = new HttpClientHandler();
        handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
        options.BackchannelHttpHandler = handler;
    }

    options.Scope.Add("email");

    options.MapInboundClaims = false;

    options.TokenValidationParameters.NameClaimType = "name";
});

builder.Services.AddHttpClient();

builder.Services.AddHttpContextAccessor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseAuthentication();
app.UseAuthorization();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();