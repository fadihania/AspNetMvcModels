using AspNetMvcModels.Models;

namespace AspNetMvcModels;

public class Data
{
    public static List<Post> Posts = new()
    {
        new Post { Id = 1, Title = "Post 1", Body = "Post 1 content", Author = "Ahmad Ali" },
        new Post { Id = 2, Title = "Post 2", Body = "Post 2 content", Author = "Saeed Mahmoud" },
        new Post { Id = 3, Title = "Post 3", Body = "Post 3 content", Author = "Osama Masoud" },
        new Post { Id = 4, Title = "Post 4", Body = "Post 4 content", Author = "Sami Suliman" }
    };
}
