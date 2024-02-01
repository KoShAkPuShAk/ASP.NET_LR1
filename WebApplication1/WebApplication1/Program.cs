var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Company company = new Company();
company.Marga = 17114;
company.Name = "Lego";
company.Location = "23/A See Road, Warsaw, Poland";
company.Year = 2000;

Random random = new Random();
int randomValue = random.Next(0, 101);


app.MapGet("/", () => "Company name: " + company.Name + " \nRandom value: " + randomValue);
app.Run();
