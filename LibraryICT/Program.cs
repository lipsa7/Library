using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryICT
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            Library l = new Library();
            List<string> BookDetails = new List<string>();

            Console.WriteLine("Enter 1 to check requirement 1, 2 to check requirement 2, 3 to check requirement 3 and so on till 6 requirements");
            var check = Console.ReadLine();

            if (check == "2")
            {
                Console.WriteLine("Enter the name of the Library: ");
                string libraryName = Console.ReadLine();



                Console.WriteLine("1.Add Book");
                Console.WriteLine("2.Delete Book");
                Console.WriteLine("3.Display Books");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Enter your choice:");

                string choice = Console.ReadLine();


                //Console.WriteLine("Enter book 1 details: ");
                //string book1 = Console.ReadLine();
                //string[] book1Array = book1.Split(',');
                //Console.WriteLine("Enter book 2 details: ");
                //string book2 = Console.ReadLine();
                //Console.WriteLine();

                //Book.CreateBook(book1);

                if (choice == "1")
                {
                    string book1 = Console.ReadLine();
                    b = Book.CreateBook(book1);
                    l.addBookToLibrary(b);
                }
                else if (choice == "2")
                {

                    Console.WriteLine("Enter the Catalog No. of the book to be deleted: ");
                    var del = Console.ReadLine();
                    if (l.RemoveBookFromLibrary(b.CatalogNo))
                    {
                        Console.WriteLine("Book successfully deleted");
                    }
                    else
                    {
                        Console.WriteLine("Book not found in the library");
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Books in " + libraryName);
                    l.DisplayBooks();
                }
                else
                {

                }
            }
            else if (check == "1")
            {




                Console.WriteLine("Enter book 1 details: ");
                string book1 = Console.ReadLine();
                string[] book1Array = book1.Split(',');
                Console.WriteLine("Enter book 2 details: ");
                string book2 = Console.ReadLine();
                Console.WriteLine();

                b.Name = book1Array[0];
                b.AuthorName = book1Array[1];
                b.Type = book1Array[2];
                b.CatalogNo = book1Array[3];
                b.PublishedDate = Convert.ToDateTime(book1Array[4]);
                b.Rating = Convert.ToDouble(book1Array[5]);
                BookDetails.Add("Name: " + b.Name);
                BookDetails.Add("Author Name: " + b.AuthorName);
                BookDetails.Add("Type: " + b.Type);
                BookDetails.Add("Catalog No: " + b.CatalogNo);
                BookDetails.Add("Published Date: " + b.PublishedDate);
                BookDetails.Add("Rating: " + Math.Round(b.Rating, 1));

                Console.WriteLine("Book 1 ");
                foreach (string i in BookDetails)
                {
                    Console.WriteLine(i);
                }


                BookDetails.Add(b.Name);



                string[] book2Array = book2.Split(',');
                b.Name = book2Array[0];
                b.AuthorName = book2Array[1];
                b.Type = book2Array[2];
                b.CatalogNo = book2Array[3];
                b.PublishedDate = Convert.ToDateTime(book2Array[4]);
                b.Rating = Convert.ToDouble(book2Array[5]);
                BookDetails.Add("Name: " + b.Name);
                BookDetails.Add("Author Name: " + b.AuthorName);
                BookDetails.Add("Type: " + b.Type);
                BookDetails.Add("Catalog No: " + b.CatalogNo);
                BookDetails.Add("Published Date: " + b.PublishedDate);
                BookDetails.Add("Rating: " + Math.Round(b.Rating, 1));

                Console.WriteLine();
                Console.WriteLine("Book 2 ");
                for (int i = 6; i < 12; i++)
                {
                    Console.WriteLine(BookDetails[i]);
                }

                //            public override bool Equals(Object obj)
                //{
                //    // Performs an equality check on two points (integer pairs).
                //    if (obj == null || GetType() != obj.GetType()) return false;
                //    Point p = (Point)obj;
                //    return (x == p.x) && (y == p.y);
                //}

            //    public override bool Equals(object obj)
            //    {
            //return true;
            //    }

        Console.WriteLine();
                if ((book1Array[0].ToUpper() == book2Array[0].ToUpper()) && (book1Array[1].ToUpper() == book2Array[1].ToUpper()))
                {
                    Console.WriteLine("Book 1 is same as Book 2");
                }
                else
                {
                    Console.WriteLine("Book 1 and Book 2 are different");
                }
            }
            else if (check == "3")
            {


                Console.WriteLine("Enter the Catalog No. to be validated: ");
                var catalogNumber = Console.ReadLine();

                
                //static not available in c# 7.3
                bool ValidateCatalogNo(string catalogNo)
                {
                    var bool1 = false;
                    char[] catalogArray = catalogNo.ToCharArray();
                    for (int i = 0; i < 3; i++)
                    {
                        if (char.IsLetter(catalogArray[i]))
                        {
                            bool1 = Char.IsUpper(catalogArray[i]);
                        }
                        if (bool1 == false)
                            break;

                    }

                    var bool2 = Char.IsWhiteSpace(catalogArray[3]);

                    var bool3 = false;
                    for (int i = 4; i < 8; i++)
                    {
                        if (Char.IsDigit(catalogArray[i]))
                        {
                            bool3 = Char.IsDigit(catalogArray[i]);
                        }
                        if (bool3 == false)
                            break;
                    }

                    var bool4=(catalogArray[8]=='-');

                    var bool5 = false;
                    var bool6 = false;
                    var bool7 = false;
                    if (catalogArray[9] == 'S' && catalogArray[10] == 'F')
                    {
                        bool5 = true;
                        if (catalogArray[11] == '-')
                            bool6 = true;
                        if (Char.IsDigit(catalogArray[12]) && Char.IsDigit(catalogArray[13]) && Char.IsDigit(catalogArray[14]) && Char.IsDigit(catalogArray[15]))
                            bool7 = true;
                    }
                        
                    else if (catalogArray[9] == 'R' && catalogArray[10] == 'O' && catalogArray[11] == 'M')
                    {
                        bool5 = true;
                        if (catalogArray[11] == '-')
                            bool6 = true;
                        if (Char.IsDigit(catalogArray[12]) && Char.IsDigit(catalogArray[13]) && Char.IsDigit(catalogArray[14]) && Char.IsDigit(catalogArray[15]))
                            bool7 = true;

                    }

                    else if (catalogArray[9] == 'H' && catalogArray[10] == 'R' && catalogArray[11] == 'R')
                    {
                        bool5 = true;
                        if (catalogArray[11] == '-')
                            bool6 = true;
                        if (Char.IsDigit(catalogArray[12]) && Char.IsDigit(catalogArray[13]) && Char.IsDigit(catalogArray[14]) && Char.IsDigit(catalogArray[15]))
                            bool7 = true;

                    }
                    else if (catalogArray[9] == 'A' && catalogArray[10] == 'N')
                    {
                        bool5 = true;
                        if (catalogArray[11] == '-')
                            bool6 = true;
                        if (Char.IsDigit(catalogArray[12]) && Char.IsDigit(catalogArray[13]) && Char.IsDigit(catalogArray[14]) && Char.IsDigit(catalogArray[15]))
                            bool7 = true;

                    }
                    else if (catalogArray[9] == 'M' && catalogArray[10] == 'Y' && catalogArray[11] == 'S')
                    {
                        bool5 = true;
                        if (catalogArray[11] == '-')
                            bool6 = true;
                        if (Char.IsDigit(catalogArray[12]) && Char.IsDigit(catalogArray[13]) && Char.IsDigit(catalogArray[14]) && Char.IsDigit(catalogArray[15]))
                            bool7 = true;

                    }
                    else if (catalogArray[9] == 'A' && catalogArray[10] == 'D' && catalogArray[11] == 'V')
                    {
                        bool5 = true;
                        if (catalogArray[11] == '-')
                            bool6 = true;
                        if (Char.IsDigit(catalogArray[12]) && Char.IsDigit(catalogArray[13]) && Char.IsDigit(catalogArray[14]) && Char.IsDigit(catalogArray[15]))
                            bool7 = true;

                    }

                    if (bool1 && bool2 && bool3 && bool4 && bool5 && bool6 && bool7)
                        return true;
                    else
                        return false;
                }

                if (ValidateCatalogNo(catalogNumber))
                    Console.WriteLine("Catalog No. is valid");
                else
                    Console.WriteLine("Catalog No. is invalid");

            }
            else if (check == "4")
            {

                BookBO bookbo = new BookBO();
                //string[] bookdetails;
                //List<Book> list1 = new List<Book>();
                List<string> list1 = new List<string>();
                Console.WriteLine("Enter the number of books: ");
                int numofbooks = Convert.ToInt32(Console.ReadLine());
                int i = 0;
                while (i < numofbooks)
                {
                    //bookdetails = Console.ReadLine().Split(',');
                    //list1.Add(bookdetails);
                    list1.Add(Console.ReadLine());
                    i++;
                }

                

                Console.WriteLine("Enter a search type: ");

                Console.WriteLine("1.By Author Name");

                Console.WriteLine("2.By Rating");

                var searchType = Console.ReadLine();

                if (searchType == "1")
                {
                    Console.WriteLine("Enter the Author Name:");
                    var name = Console.ReadLine();
                    var list2=bookbo.FindBook(list1, name);

                    if (!list2.Any())
                    {
                        Console.WriteLine("No such book is present");
                    }
                    else
                    {
                        Console.WriteLine("        Author                      Published ");
                        Console.WriteLine("Name    Name    Type    Catalog No    Date    Rating");
                        foreach (string item in list2)
                        {
                            Console.Write(item + "    ");
                        }
                    }

                }
                else if(searchType=="2")
                {
                    Console.WriteLine("Enter the Rating:");
                    var rating = Convert.ToDouble(Console.ReadLine());
                    var list2=bookbo.FindBook(list1, rating);

                    if (!list2.Any())
                    {
                        Console.WriteLine("No such book is present");
                    }
                    else
                    {
                        Console.WriteLine("        Author                      Published ");
                        Console.WriteLine("Name    Name    Type    Catalog No    Date    Rating");
                        foreach (string item in list2)
                        {
                            Console.Write(item + "    ");
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
                    
            }
            else if (check == "5")
            {
                List<string> list2=new List<string>();
                int num;
                int choice;

                Book book = new Book();
                //List<Book> list1 = new List<Book>();
                
                PublishedDateComparer publishedDateComparer = new PublishedDateComparer();
                Console.WriteLine("Enter the number of books: ");
                num = Convert.ToInt32(Console.ReadLine());

                for(int i = 1; i <= num; i++)
                {
                    list2.Add(Console.ReadLine());
                    
                }

                Console.WriteLine("Enter a type to sort: ");
                Console.WriteLine("1.Sort by Name ");
                Console.WriteLine("2.Sort by Published Date");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {                   
                    Book bo = new Book();
                    List<string[]> list3 = new List<string[]>();
                    for(int i = 0; i < list2.Count; i++)
                    {
                        list3.Add(list2[i].Split(','));
                    }

                    List<string> m = new List<string>();
                    for(int i = 0; i < list3.Count; i++)
                    {
                        m.Add(list3[i][0]);
                    }

                    m.Sort(bo);

                    Console.WriteLine("Name  Author Name  Type  Catalog No  Published Date  Rating");
                    for(int i = 0; i < m.Count; i++)
                    {
                        for(int j = 0; j < list3.Count; j++)
                        {
                            if (m[i] ==list3[j][0])
                            {
                                foreach (string item in list3[j])
                                {
                                    Console.Write(item + "  ");

                                }
                                Console.WriteLine();
                            }
                        }
                    }


                }
                else if (choice == 2)
                {
                    PublishedDateComparer pbd = new PublishedDateComparer();
                    List<string[]> list3 = new List<string[]>();
                    for (int i = 0; i < list2.Count; i++)
                    {
                        list3.Add(list2[i].Split(','));
                        
                    }

                    List<DateTime> k = new List<DateTime>();
                    for(int i = 0; i < list3.Count; i++)
                    {
                         k.Add(Convert.ToDateTime(list3[i][4]));
                            
                    }

                    k.Sort(pbd);

                    Console.WriteLine("Name  Author Name  Type  Catalog No  Published Date  Rating");
                    for(int i = 0; i < k.Count; i++)
                    {
                        for(int j = 0; j < list3.Count; j++)
                        {
                            if (k[i] == Convert.ToDateTime(list3[j][4]))
                            {
                                foreach (string item in list3[j])
                                {
                                    Console.Write(item + "  ");
                                    
                                }
                                Console.WriteLine();
                            }
                        }
                        

                        
                    }

                }
                
            }
            else if (check == "6")
            {
                //Book b1;
                List<string> list1 = new List<string>();
                Console.WriteLine("Enter the number of books: ");
                int numofbooks = Convert.ToInt32(Console.ReadLine());

                int i = 0;
                while (i < numofbooks)
                {
                    //b1 = new Book();
                    //b1.Input = Console.ReadLine();
                    list1.Add(Console.ReadLine());
                    i++;
                }

                var dictionary=Book.TypeWiseCount(list1);

                var list = dictionary.Keys.ToList();
                list.Sort();

                Console.WriteLine("Book Type     Count");
                foreach(var key in list)
                {
                    Console.WriteLine("{0}: {1}", key, dictionary[key]);
                }
                
            }
            Console.ReadKey();
        }
    }
}
