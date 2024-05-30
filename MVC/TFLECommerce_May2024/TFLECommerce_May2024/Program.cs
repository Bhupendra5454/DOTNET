using TFLECommerce_May2024.Controllers;
using TFLECommerce_May2024.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

List<Customer> customers = new List<Customer>();
customers.Add(new Customer { Id = 54, Name = "Bhupendra Walhekar", Email = "bhupendraw2512@gmail.com", Phone = "9175116616" });
customers.Add(new Customer { Id = 11, Name = "Vaibhav Lakudzode", Email = "vaibhavl@gmail.com", Phone = "9175116617" });
customers.Add(new Customer { Id = 45, Name = "Shreedhar Patil", Email = "shreedharp@gmail.com", Phone = "9175116618" });
customers.Add(new Customer { Id = 97, Name = "Ajinkya Tambade", Email = "ajinkyat@gmail.com", Phone = "9175116619" });

app.MapAreaControllerRoute(
    name: "default",
    pattern: "{controller=Customer}/{action=Index}/{customer=customers}");




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
