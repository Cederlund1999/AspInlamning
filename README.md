# AspInlamning
ASP.NET Core är ett open-source web-framework som kan användas för att bygga snabba och säkra webapps/services. 
Det är också cross-platform så det går att köra på windows, linux, mac-os osv. 
ASP.NET Core erbjuder även Razor. Razor används för att kunna skriva server baserad kod på webbsidor. Det går alltså att använda C# kod tillsammans med HTML kod. 

//En kort text i README som beskriver vilka delar som ingår i en RazorPages applikation och kortfattat om hur de olika delarna hänger ihop.

I en Razor Pages Applikation ingår Startup.cs, Program.cs, Appsettings.json, wwwroot, och pages mappen. 

Startup.cs innehåller ConfigureServices och Configure. I ConfigureServices lägger vi in vilka services vi vill ha. Dom går sedan att nå via Dependency Injection. I Configure väljer vi hur vår app ska aggera när den får in en request, genom middlewares såsom t.ex app.UseHttpsRedirection(); m.m.

Program.cs är våran entry point i webbapplikationen. Det är i program.cs allt börjar när vi kör våran app.

Appsettings.json är en konfigurationsfil. Där lägger man in t.ex connection string till databasen.

wwwroot innehåller statiska filer, såsom html, css och javascript filer som ska se likadana ut varje gång en användare gör en request om det. Samt olika libraries som bootstrap m.m.

Pages mappen innehåller alla razor pages. Varje razor page har två delar. Content page och PageModel. 
Content page har hand om allt i UIn. Hur sidan ska se ut. I en Content page kan man använda razor kod och en referens till Model som använder PageModel.

I PageModel har man allt logik och kommunikation med annan kod. Där kan man använda sig av page handlers såsom OnGet och OnPost för att hantera HTTP GET/POST requests. När vi laddar en ny sida så är det alltid en ny pagemodel som skapas.

En kort text i README som beskriver vilka delar som ingår i en MVC applikation och kortfattat om hur de olika delarna hänger ihop. 
Det vi får i MVC som vi inte har i Razor pages är Models, Views och Controllers. 

I controller har vi Action metoder. Controllern och action metoderna hanterar inkommande requests från webbläsaren. Och sedan returnerar t.ex rätt View tillsbaks till användaren.

Views är Uin. Där vi presenterar data och de usern kan interagera med. 

I Models definierar vi egenskaperna för datan som kommer att lagras i databasen.
