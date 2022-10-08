using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Task_004.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Range(1, 5000, ErrorMessage = "Too many pages... Recheck the quontity!")]
        [DisplayName("Page QTY")]
        public int PageQty { get; set; }

        public Genre Genre { get; set; }
        public ICollection<Author> Authors { get; set; } = new List<Author>();

        public override string ToString()
        {
            return $"\"{Name}\", {PageQty} page(s) total and it's \"{Genre}\" by genre";
        }
    }

    public enum Genre : byte
    {
        AvantGarde, Action, Detective,
        Historical, Love
    }
}
