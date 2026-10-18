using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Criste_Anamaria_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }     
        public string LastName { get; set; }      
        public ICollection<Book>? Books { get; set; }
        [NotMapped]
        [Display(Name = "Author")]
        public string FullName => FirstName + " " + LastName;
    }
}
