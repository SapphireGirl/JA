using System.ComponentModel.DataAnnotations;

namespace JA.Models.ProductModels
{

    public class Tag
    {
        public int TagId { get; private set; }

        public int BlogId { get; private set; }
    //       public Blog Blog { get; private set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
    }
    
}