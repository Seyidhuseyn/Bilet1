using System.ComponentModel.DataAnnotations.Schema;

namespace Bilet11.ViewModels
{
    public class CreatePostVM
    {
        public string ImageUrl { get; set; }
        public string PrimaryTitle { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
    }
}
