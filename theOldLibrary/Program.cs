using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theOldLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int bookCount = 0;
            bool isBookFound = false;
            string currentBook = Console.ReadLine();
            while (currentBook!="No more books")
            {
                if(currentBook==bookName)
                
                    isBookFound = true;
                    Console.WriteLine($"You checked {bookCount} books and found it.");
                
               break;
                bookCount += 1;
                currentBook = Console.ReadLine();

                if (isBookFound != false)
                {
                    Console.WriteLine("The  book you search is not here!");
                    Console.WriteLine($"You checked {bookCount} books.");
                }
            }
          

        }
    }
}
