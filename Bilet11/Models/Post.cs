using Bilet11.Models.Base;

namespace Bilet11.Models
{
    public class Post:BaseIdentity
    {
        public string ImageUrl { get; set; }
        public string PrimaryTitle { get; set; }
        public string Description{ get; set; }
        public DateTime Date { get; set; }
    }
}
