namespace Task_004.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PageQty { get; set; }
        public Genre Genre { get; set; }
        public ICollection<Author> Authors { get; set; } = new List<Author>();

        public override string ToString()
        {
            return $"{Name} {PageQty} {Genre}";
        }
    }

    public enum Genre : byte
    {
        AvantGarde, Action, Detective,
        Historical, Love, Mystic,
        Adventures, Thriller, Horror
    }
}
