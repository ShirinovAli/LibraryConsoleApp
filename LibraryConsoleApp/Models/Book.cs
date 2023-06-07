namespace LibraryConsoleApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public string CategoryName { get; set; }
        public Author Author { get; set; }
        public string AuthorName { get; set; }
    }
}
