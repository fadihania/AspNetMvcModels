using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcModels.Controllers;
public class PostsController : Controller
{
    public IActionResult Index()
    {
        var post = Data.Posts[0];
        return View(post);
    }
}
