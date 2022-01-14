var a = WebApplication.CreateBuilder().Build();
a.MapGet("/", () => System.DateTime.Now + " - Minimal ASP.NET Core Hosting...");
a.Run();