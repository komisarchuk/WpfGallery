using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfGallery.Entities
{
    [Table("tblPictures")]
    public class Picture
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(maximumLength: 500)]
        public string Path { get; set; }
        public int Category { get; set; }
    }
}
