namespace LibraryConsoleApp.Models
{
    public class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Book[] Books { get; set; }

        public string GetDetails()
        {
            return $"{this.Name} {this.Address} {this.PhoneNumber} {this.Email}";
        }

        public int GetBooksCount()
        {
            return this.Books.Length;
        }

        public void AddBook(Book book)
        {
            this.Books[0] = book;
        }
    }
}
