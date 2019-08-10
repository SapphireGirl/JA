using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JA.ModelsCore.Shared
{
    public class Tag
    {
        public int TagId { get; private set; }

        public int BlogId { get; private set; }
        //       public BlogPost BlogPost { get; private set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
