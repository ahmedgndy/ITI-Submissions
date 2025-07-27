
using System.Xml.Linq;

namespace problem_1_day_5_oop
{
    internal class Program
    {
        Visitor visitor; 
        static void Main(string[] args)
        {
            int x = 5;
            string  y = new string('a', 2);

            Visitor v = new  Visitor("Ahmed" , "ahmed@gmail.com" ,"0918410284") ;
            Book book1 = new Book("this is a long book to tessssst ", "faction", "dff" ,"df");
            Book book2 = new Book("this is a long book to tessssst ", "faction", "dff", "df");
            Book book3 = new Book("this is a long book to tessssst ", "faction", "dff", "df");

            v.addToVisitedBook(book1);
            v.addToVisitedBook(book2);

            v.addToVisitedBook(book3);

            v.printVisitedBooks();
                     
        }
    }
}
