using Microsoft.AspNetCore.Mvc;

namespace MVC_EF_Start.Controllers
{
  public class HomeController : Controller
  {
    public ApplicationDbContext dbContext;

    public HomeController(ApplicationDbContext context)
    {
      dbContext = context;
    }

    public IActionResult Index()
    {
      Company MyCompany = new Company();
      MyCompany.symbol = "ISM6225";
      MyCompany.name = "ISM";
      MyCompany.date = "ISM";
      MyCompany.isEnabled = true;
      MyCompany.type = "ISM";
      MyCompany.iexId = "ISM";

      dbContext.Companies.Add(MyCompany);
      dbContext.SaveChanges();
    }
  }
}