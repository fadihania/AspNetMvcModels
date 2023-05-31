using AspNetMvcModels.Models;
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

    [HttpPost]
    public IActionResult Create(Post post)
    {
        if (!ModelState.IsValid)
        {
            return View(post);
        }

        _data.Posts.Add(post);
        return RedirectToAction("Index");
    }
}
