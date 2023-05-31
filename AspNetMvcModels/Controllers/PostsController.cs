using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcModels.Controllers;
public class PostsController : Controller
{
    private readonly Data _data;

    public PostsController(Data data)
    {
        _data = data;
    }

    public IActionResult Index()
    {
        return View(_data.Posts);
    }

    public IActionResult Create()
    {
        return View();
    }
}
