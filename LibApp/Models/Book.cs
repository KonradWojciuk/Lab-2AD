using System.ComponentModel.DataAnnotations;

namespace LibApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The Title field is required.")]
        public string Title { get; set; }
        public string Author { get; set; }
        public Genre Genre { get; set; }
        [Required(ErrorMessage = "The GenreId field is required.")]
        public byte GenreId { get; set; }
        public DateTime DateAdded { get; set; }
        [Required(ErrorMessage = "The ReleaseDate field is required.")]
        public DateTime? ReleaseDate { get; set; }
        [Required(ErrorMessage = "The NumberInStock field is required.")]
        [Range(1, 20, ErrorMessage = "The NumberInStock field must be lower then 20 and higher then 1.")]
        public int NumberInStock { get; set; }
    }
}
