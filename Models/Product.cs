using System.ComponentModel.DataAnnotations;

namespace RepositoryPattern.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter item name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter item description")]
        public string Descriptions { get; set; }
        [Required(ErrorMessage = "Please enter item price")]
        public string Price { get; set; }
    }
}
