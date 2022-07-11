var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


//string name = "Семенов Никита Денисович";
//string date = "21/09/2001";
//string lan = "C++";
//int exp = 1;
//string phone = "+79686586316";

//CreateUser(name, date, lan, exp, phone);

//void CreateUser(string name, string date, string lan, int exp, string phone)
//{
//    Person person = new Person(name, date, lan, exp, phone);
//    var context = new ValidationContext(person);
//    var results = new List<ValidationResult>();
//    if (!Validator.TryValidateObject(person, context, results, true))
//    {
//        Console.WriteLine("Не удалось создать объект User");
//        foreach (var error in results)
//        {
//            Console.WriteLine(error.ErrorMessage);
//        }
//        Console.WriteLine();
//    }
//    else
//        Console.WriteLine($"Объект Person успешно создан");
//}
