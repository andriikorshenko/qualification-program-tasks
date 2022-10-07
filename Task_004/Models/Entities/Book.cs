﻿namespace Task_004.Models.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PageQty { get; set; }
        public Genre Genre { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }

    public enum Genre : byte
    {
        AvantGarde, Action, Detective, 
        Historical, Love, Mystic, 
        Adventures, Thriller, Horror
    }
}