using System.ComponentModel.DataAnnotations;

namespace Task_004.Models.Entities
{
    public class Author
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Required]
        public DateTime BirthDate { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
