using System.ComponentModel.DataAnnotations;

namespace NewLibrary.Models
{
    public class Author
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }



    }
}
