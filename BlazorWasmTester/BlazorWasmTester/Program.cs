using BlazorWasmTester;
using BlazorWasmTester.Features.SimpleSQLiteTest;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using SqliteWasmHelper;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddMudServices();

builder.Services.AddSqliteWasmDbContextFactory<NotesDbContext>(
  opts => opts.UseSqlite("Data Source=notes.sqlite3"));

//builder.Services.AddScoped<INotesRepository, NotesRepository>();

// Register the NotesRepository service.
//builder.Services.AddScoped<INotesRepository, NotesRepository>(notesRepository =>
//{
//    //var context = new NotesDbContext(new SqliteConnection("Data Source=notes.sqlite3"));
//    var context = new NotesDbContext(new DbContextOptionsBuilder().UseSqlite(""));
//    return new NotesRepository(context);
//});

await builder.Build().RunAsync();



