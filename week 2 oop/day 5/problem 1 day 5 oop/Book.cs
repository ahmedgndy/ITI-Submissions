using System.Runtime.InteropServices;

namespace problem_1_day_5_oop
{
    public class Book
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Edition { get; set; }
        public string AuthorName { get; set; }


        public Book(string name, string category, string edition, string authorname)
        {
            this.Name = name;
            this.Category = category;
            this.Edition = edition;
            this.AuthorName = authorname;

        }

        Book(Book book) {
            this.Name = book.Name;
        }   
        
    }
}
