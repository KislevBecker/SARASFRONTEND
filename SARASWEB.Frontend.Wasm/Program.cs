using Blazored.Modal;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SARASWEB.Frontend.Aplicacion.ListasGeneralesAplicacion.BancosAplicacion;
using SARASWEB.Frontend.Aplicacion.ListasGeneralesAplicacion.MonedasAplicacion;
using SARASWEB.Frontend.Aplicacion.ListasGeneralesAplicacion.TipoCuentasAplicacion;
using SARASWEB.Frontend.Aplicacion.ListasGeneralesAplicacion.TipoDocumentoAplicacion;
using SARASWEB.Frontend.Aplicacion.ProductosAplicacion;
using SARASWEB.Frontend.Controlador.TransferenciaPropiaControlador;
using SARASWEB.Frontend.Controlador.TransferenciaTercerosControlador;
using SARASWEB.Frontend.FuenteDatos.HttpRepositorio;
using SARASWEB.Frontend.PD.GenericaPersistenciaDatos;
using SARASWEB.Frontend.PD;
using SARASWEB.Frontend.Transversal.Helpers;
using SARASWEB.Frontend.Wasm;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("http://192.168.1.67:9008")
});
builder.Services.AddTransient<IHelper, Helper>();
builder.Services.AddTransient<IHttpRepositorio, HttpRepositorio>();
builder.Services.AddTransient<ITransferenciaPropiaControlador, TransferenciaPropiaControlador>();
builder.Services.AddTransient<ITransferenciaTercerosControlador, TransferenciaTercerosControlador>();
builder.Services.AddTransient<IGenericaPersistenciaDatos, GenericaPersistenciaDatos>();
builder.Services.AddTransient<IProductoAplicacion, ProductoAplicacion>();
builder.Services.AddTransient<IBancosAplicacion, BancosAplicacion>();
builder.Services.AddTransient<IMonedasAplicacion, MonedasAplicacion>();
builder.Services.AddTransient<ITipoCuentasAplicacion, TipoCuentasAplicacion>();
builder.Services.AddTransient<ITipoDocumentoAplicacion, TipoDocumentoAplicacion>();
builder.Services.AddBlazoredModal();
builder.Services.AddBlazoredSessionStorage();
builder.Services.AddAuthorizationCore();
builder.Services.AddBlazoredSessionStorage(config =>
config.JsonSerializerOptions.WriteIndented = true);
await builder.Build().RunAsync();

await builder.Build().RunAsync();
