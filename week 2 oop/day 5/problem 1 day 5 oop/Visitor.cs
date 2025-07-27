using System.Runtime.CompilerServices;

namespace problem_1_day_5_oop
{
    public class Visitor
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        private List<Book> books { get; set; } = new List<Book>();
        //default 
        public Visitor()
        {
            name = "visitor user";
            email = null;
            phoneNumber = null;
        }

        //Parameterized Constructo

        public Visitor(string name, string email, string phoneNumber)
        {
            this.name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

        //copy constrector

        public Visitor(Visitor visitor)
        {
            this.email = visitor.email;
            this.phoneNumber = visitor.phoneNumber;
            this.name = visitor.name;
        }

        public void addToVisitedBook(Book book)
        {
            books.Add(book);
        }

        public void printVisitedBooks()
        {
            Console.WriteLine(books.Count);
            if (books != null)
            {
               
                for (int i = 0; i < books.Count; i++)
                {
                    Console.WriteLine($"{books[i].Name}");
                }
            }
        }
     
    }
}
