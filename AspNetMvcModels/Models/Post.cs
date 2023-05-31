using System.ComponentModel.DataAnnotations;

namespace AspNetMvcModels.Models;

public class Post
{
    [Required]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Title { get; set; }


    public string? Body { get; set; }

    [Required]
    [MinLength(15)]
    public string Author { get; set; }
}
