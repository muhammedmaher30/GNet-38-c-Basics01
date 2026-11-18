
using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace first_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // class Book
            //{
            //  public string Title = "C# Basics";
            //public int Pages = 200;
            //}
            //static void Main(string[] args)
            //{
            #region  Question-1 
            // 1-All questions use the same theme: a Book with a Title and Pages. Try each one yourself
            //before checking the answer.
            ///string Title = "Css Basics";
            ///int Pages = 200;
            ///Console.WriteLine("Book Title: " + Title);
            ///Console.WriteLine("Book Pages: " + Pages);

            #endregion

            #region Question 2  
            //Create a Book class with a Title (string) and Pages (int). Create a Book object and store it
            //in a variable of type object.Print it.
            ///object book = new Book();
            ///Console.WriteLine(book);
            #endregion

            #region Question 3 
            //Using the Book class above, print the result of calling ToString(), Equals() (compare book
            //with itself), GetHashCode(), and GetType() on book.
            /// object book = new Book();
            /// Console.WriteLine(book.ToString());
            ///  Console.WriteLine(book.Equals(book));
            /// Console.WriteLine(book.GetHashCode());
            /// Console.WriteLine(book.GetType());
            #endregion
            #region     Qustion 4
            //Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            //int pages = "464";
            //  Compile - time error — you can't put text (string) into an int variable.
            //int pages = 464;
            /// int pages = 464;
            ///Console.WriteLine(pages);
            #endregion

            #region Qustion 5 
            //Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot
            //divide by zero", and then prints "Done" in a finally block.
            /// try
            //{
            //  int x = 0;
            //int result = 10 / x;
            //}
            //catch (DivideByZeroException)
            //{
            //  Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //  Console.WriteLine("Done");
            //}
            #endregion

            #region Question 6 
            //Declare an int pages = 300; then store it in a double variable without using a cast.
            //int pages = 300;
            //double result = pages;
            // Console.WriteLine(result);
            #endregion

            #region Question 7 
            //Declare a double price = 49.99; then convert it into an int using a cast.
            // double price = 49.99;
            // int result = (int)price;
            // Console.WriteLine(result);
            #endregion
            #region Question 8 
            //Given string pagesText = "464";, convert it into an int using the Convert class.
            //string pagesText = "464";
            //  int pages = Convert.ToInt32(pagesText);
            //Console.WriteLine(pages);
            #endregion
            #region Question 9 
            //Given string yearText = "2023";, convert it using int.Parse(). Then given string badText =
            //00"abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            // string yearText = "2023";
            //int year = int.Parse(yearText);
            //Console.WriteLine(year);
            //string badText = "abc";
            //if (int.TryParse(badText, out int number))
            //{
            //   Console.WriteLine(number);
            //}
            //else
            //{
            //  Console.WriteLine("Invalid number");
            //}

            #endregion

            #region Question 10
            //Given int pages = 464;, convert it into a string using ToString() and print its type using
            //GetType() to prove it's now a string.
            //int pages = 464;
            //string pagesText = pages.ToString();
            // Console.WriteLine(pagesText);
            // Console.WriteLine(pagesText.GetType());
            #endregion

            #region Question 11
            //Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int
            // variable, and print both.
            int copies = 100;
            object obj = copies;
            int newCopies = (int)obj;
            Console.WriteLine(obj);
            Console.WriteLine(newCopies);
            #endregion
        }
    }
    }

