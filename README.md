# AspInlamning
ASP.NET Core är ett open-source web-framework som kan användas för att bygga snabba och säkra webapps/services. 
Det är också cross-platform så det går att köra på windows, linux, mac-os osv. 
ASP.NET Core erbjuder även Razor. Razor används för att kunna skriva server baserad kod på webbsidor. Det går alltså att använda C# kod tillsammans med HTML kod. 


I en Razor Pages Applikation ingår Startup.cs, Program.cs, Appsettings.json, wwwroot, och pages mappen. 
Startup.cs innehåller kod som ställer in hur webbapplikationen ska fungera. Hur webbapplikationen ska hantera requests som användaren gör.
Program.cs är våran entry point i webbapplikationen. Det är i program.cs allt börjar när vi kör våran app.
Appsettings.json är en konfigurationsfil. Där lägger man in t.ex connection string till databasen.
wwwroot innehåller statiska filer, såsom html, css och javascript filer som ska se likadana ut varje gång en användare gör en request om det. Samt olika libraries som bootstrap m.m.
Pages mappen innehåller alla razor pages. Varje razor page har två delar. Content page och PageModel. 
