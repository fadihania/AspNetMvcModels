using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcModels.Controllers;
public class PostsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
