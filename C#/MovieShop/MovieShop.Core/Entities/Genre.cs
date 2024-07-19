using System.ComponentModel.DataAnnotations;

namespace MovieShop.Core.Entities;

public class Genre
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }

    public List<MovieGenres> MovieGenres { get;} = [];
    public List<Movie> Movies { get;} = [];
}