using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Classes_and_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Book book1 = new Book();// creat a new book book object, at this point Book is now a data type in C#

            //Creation of first book, you can now create thousands of different books eg for a library app!
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord of the rings";
            book2.author = "Tolkein";
            book2.pages = 900;
            
            Book book3 = new Book();
            book3.title = "the mountain is you";
            book3.author = "Brianna Wiest";
            book3.pages = 248;

            Member member = new Member();

            member.name = "Thabile";
            member.age = 30;
            member.address = "84 Marshall";
            member.phone = 0717222594;

            Console.WriteLine(member.address);
            Console.WriteLine(member.phone);



            Console.WriteLine(book1.pages);
            Console.WriteLine(book2.title);
            Console.WriteLine(book3.author);
            //freeze
            Console.ReadLine();
        }
    }
}
