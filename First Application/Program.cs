namespace first_Application
{
    internal class Program
    {
        class Book
        {
            public string Title = "C# Basics";
            public int Pages = 200;
        }
        static void Main(string[] args)
        {
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
            object book = new Book();
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());
            #endregion
        }
    }
    }

